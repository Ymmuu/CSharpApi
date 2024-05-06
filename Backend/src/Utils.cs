namespace WebApp;

public static class Utils
{

    /*
    public static Arr CreateMockUsers()
    {
        // Read all mock users from the JSON file
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        Arr successFullyWrittenUsers = Arr();
        foreach (var user in mockUsers)
        {
            user.password = "12345678";
            var result = SQLQueryOne(
                @"INSERT INTO users(firstName,lastName,email,password)
                VALUES($firstName, $lastName, $email, $password)
            ", user);
            // If we get an error from the DB then we haven't added
            // the mock users, if not we have so add to the successful list
            if (!result.HasKey("error"))
            {
                // The specification says return the user list without password
                user.Delete("password");
                successFullyWrittenUsers.Push(user);
            }
        }
        return successFullyWrittenUsers;
    }
    */


    /*
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
        */
    



    public static string RemoveBadWords(string input, string expectedOutput)
    {
        var read = File.ReadAllText(Path.Combine("json", "bad-words.json"));
        Arr badWords = JSON.Parse(read);

        foreach (var badWord in badWords)
        {
            input = input.Replace(badWord, expectedOutput);
        }

        return input;
    }


}