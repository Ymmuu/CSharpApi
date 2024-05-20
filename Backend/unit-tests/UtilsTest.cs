namespace WebApp;


public class UtilsTest(Xlog Console)
{
    // Note: You need to use the following command line command
    // dotnet r unit-tests
    private static readonly Arr mockUsers = JSON.Parse(
        File.ReadAllText(FilePath("json", "mock-users.json"))
    );
    

    
    [Fact]
    public void TestCreateMockUsers()
    {
        Arr usersInDb = SQLQuery("SELECT email FROM users");
        Arr emailsInDb = usersInDb.Map(user => user.email);

        Arr mockUsersNotInDb = mockUsers.Filter(
            mockUser => !emailsInDb.Contains(mockUser.email)
        );

        var result = Utils.CreateMockUsers();

        // Assert that the CreateMockUsers only return
        // newly created users in the db
        Console.WriteLine($"The test expected that {mockUsersNotInDb.Length} users should be added.");
        Console.WriteLine($"And {result.Length} users were added.");
        Console.WriteLine("The test also asserts that the users added " + "are equivalent (the same) to the expected users!");
        Assert.Equivalent(mockUsersNotInDb, result);
        Console.WriteLine("The test passed!");
    }
    
    
    
    [Theory]
    [InlineData("abC9#fgh", true)]  // ok
    [InlineData("stU5/xyz", true)]  // ok too
    [InlineData("abC9#fg", false)]  // too short
    [InlineData("abCd#fgh", false)] // no digit
    [InlineData("abc9#fgh", false)] // no capital letter
    [InlineData("abC9efgh", false)] // no special character
    public void TestIsPasswordGoodEnough(string password, bool expected)
    {
        Assert.Equal(expected, Utils.IsPasswordGoodEnough(password));
    }
    


    /* 
    // Skrev denna själv med fick inte rätt på tex "hello", då suddades "hell" ut och skrevs ut ****o.

    [Fact]
    public void TestRemoveBadWords()
    {
        var read = File.ReadAllText(FilePath("json", "bad-words.json"));
        Arr badWords = JSON.Parse(read);

        var input = "Hello. This is a test sentence with fuck, hell and shit.";
        var expectedOutput = "Hello. This is a test sentence with ****, **** and ****.";
        var result = Utils.RemoveBadWords(input, "****");
        Assert.Equal(expectedOutput, result);

        Console.WriteLine($"{result}");

    }
    */

    [Theory]
    [InlineData(
        "---",
        "Hello, I am going through hell. Hell is a real fucking place " +
            "outside your goddamn comfy tortoiseshell!",
        "Hello, I am going through ---. --- is a real --- place " +
            "outside your --- comfy tortoiseshell!"
    )]
    [InlineData(
        "---",
        "Rhinos have a horny knob? (or what should I call it) on " +
            "their heads. And doorknobs are damn round.",
        "Rhinos have a --- ---? (or what should I call it) on " +
            "their heads. And doorknobs are --- round."
    )]
    public void TestRemoveBadWords(string replaceWith, string original, string expected)
    {
        Assert.Equal(expected, Utils.RemoveBadWords(original, replaceWith));
    }



    [Fact]
    public void TestCountDomainsFromUserEmails()
    {
        var usersDb = SQLQuery(@"SELECT email FROM users");
        Obj result = Utils.CountDomainsFromUserEmails();
        Assert.True(result.GetKeys().Count() > 0);

        int numberOfDomains = result.GetKeys().Count();
        Console.WriteLine($"There are {numberOfDomains} different domains registered.");
    }


    
    [Fact]
    public void TestRemoveMockUsers()
    {
        Arr usersBeforeRemoval = SQLQuery("SELECT email FROM users");
        var successfullyRemovedUsers = Utils.RemoveMockUsers();
        Arr usersAfterRemoval = SQLQuery("SELECT email FROM users");

        Assert.IsType<Arr>(successfullyRemovedUsers);
        foreach (var user in successfullyRemovedUsers)
        {
            Assert.False(user.HasKey("password"));
            Assert.Contains(user.email, usersBeforeRemoval.Map(u => u.email));
            Assert.DoesNotContain(user.email, usersAfterRemoval.Map(u => u.email));
        }

        Assert.Equal(usersBeforeRemoval.Length - successfullyRemovedUsers.Length, usersAfterRemoval.Length);

        // To print out all removed users without passwords
        //Console.WriteLine($"{successfullyRemovedUsers}");
    }
    
}