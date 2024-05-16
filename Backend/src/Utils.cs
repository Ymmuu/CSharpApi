namespace WebApp;

public static class Utils
{

    // Read all mock users from file
    private static readonly Arr mockUsers = JSON.Parse(
        File.ReadAllText(FilePath("json", "mock-users.json"))
    );

    private static readonly Arr badWords = ((Arr)JSON.Parse(
        File.ReadAllText(FilePath("json", "bad-words.json"))
    )).Sort((a, b) => ((string)b).Length - ((string)a).Length);


    public static Arr CreateMockUsers()
    {
        Arr successFullyWrittenUsers = Arr();

        foreach (var user in mockUsers)
        {
            // user.password = "12345678";
            var result = SQLQueryOne(
                @"INSERT INTO users(firstName,lastName,email,password)
                VALUES($firstName, $lastName, $email, $password)
            ", user);

            if (!result.HasKey("error"))
            {
                user.Delete("password");
                successFullyWrittenUsers.Push(user);
            }
        }
        return successFullyWrittenUsers;
    }


    public static Obj CountDomainsFromUserEmails()
        {
            Arr users = SQLQuery("SELECT email FROM users");
            Dictionary<string, int> domainCounts = new Dictionary<string, int>();

            foreach (var user in users)
            {
                string email = (string)user.email;
                string domain = email.Split('@')[1];

                if (domainCounts.ContainsKey(domain))
                    domainCounts[domain]++;
                else
                    domainCounts[domain] = 1;
            }

            Obj result = Obj();
            foreach (var kvp in domainCounts)
            {
                result[kvp.Key] = kvp.Value;
            }

            return result;
        }


    public static bool IsPasswordGoodEnough(string password)
    {
        return password.Length >= 8
            && password.Any(Char.IsDigit)
            && password.Any(Char.IsLower)
            && password.Any(Char.IsUpper)
            && password.Any(x => !Char.IsLetterOrDigit(x));
    }
        
    
    /*
    // Skrev denna själv med fick inte rätt på tex "hello", då suddades "hell" ut och skrevs ut ****o.

    public static string RemoveBadWords(string input, string expectedOutput)
    {
        var read = File.ReadAllText(FilePath("json", "bad-words.json"));
        Arr badWords = JSON.Parse(read);

        foreach (var badWord in badWords)
    {
        input = input.Replace(badWord.Value.ToString(), expectedOutput);
    }

        return input;
    }
    */

    public static string RemoveBadWords(string comment, string replaceWith = "---")
    {
        comment = " " + comment;
        replaceWith = " " + replaceWith + "$1";
        badWords.ForEach(bad =>
        {
            var pattern = @$" {bad}([\,\.\!\?\:\; ])";
            comment = Regex.Replace(
                comment, pattern, replaceWith, RegexOptions.IgnoreCase);
        });
        return comment[1..];
    }
    

    public static Arr RemoveMockUsers()
    {
        Arr successfullyRemovedUsers = Arr();

        foreach (var user in mockUsers)
        {
            var result = SQLQueryOne(
                @"DELETE FROM users
                WHERE email = $email",
                new { email = user.email }
            );

            if (!result.HasKey("error"))
            {
                user.Delete("password");
                successfullyRemovedUsers.Push(user);
            }
        }

        return successfullyRemovedUsers;
    }
    

}