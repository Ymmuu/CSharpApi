namespace WebApp;

public static class Utils
{
   
    public static Arr CreateMockUsers()
    {
        var read = File.ReadAllText(Path.Combine("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        Arr sucessFullyWrittenUsers = Arr();
        foreach(var user in mockUsers)
        {
            user.password = "12345678";
            var result = SQLQueryOne(
            @"INSERT INTO users(firstName, lastName, email, password)
            VALUES($firstName, $lastName, $email, $password)
            ", user);
            // If we get error from DB, we havent added the MockUser, if not we have added to the list sucessful.
            if(!result.HasKey("error"))
            {
                // The spec says return the user list without password
                user.Delete("password");
                sucessFullyWrittenUsers.Push(user);
            }
        }
        return sucessFullyWrittenUsers;
    }


    public static bool IsPasswordGoodEnough(string password)
    {
        if (password.Length < 8)
            return false;

        if (!password.Any(char.IsLower) || !password.Any(char.IsUpper))
            return false;

        if (!password.Any(char.IsDigit))
            return false;

        if (password.All(char.IsLetterOrDigit))
            return false;

        return true;
    }


    public static string RemoveBadWords(string input, string output)
    {
        var read = File.ReadAllText(Path.Combine("json", "bad-words.json"));
        Arr badWords = JSON.Parse(read);

        foreach (var badWord in badWords)
        {
            input = input.Replace(badWord, output);
        }

        return input;
    }


}