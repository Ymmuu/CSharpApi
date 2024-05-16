using Xunit;
using Xunit.Abstractions;

namespace WebApp;
public class UtilsTest
{
    // Note: You need to use the following command line command
    // dotnet r unit-tests
    private readonly ITestOutputHelper output;
    public UtilsTest(ITestOutputHelper output)
    {
        this.output = output;
    }
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
       
        output.WriteLine($"The test expected that {mockUsersNotInDb.Length} users should be added.");
        output.WriteLine($"And {result.Length} users were added.");
        output.WriteLine("The test also asserts that the users added " +
            "are equivalent (the same) to the expected users!");
        Assert.Equivalent(mockUsersNotInDb, result);
        output.WriteLine("The test passed!");
    }
    


    [Fact]
        public void TestCountDomainsFromUserEmails()
        {
            Obj expectedResult = Obj();
            expectedResult["example.com"] = 3; // Uppdatera detta med det faktiska antalet användare

            // Kör metoden för att räkna domäner från användar-e-postadresser
            Obj result = Utils.CountDomainsFromUserEmails();

            Assert.Equal(expectedResult, result);
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

        output.WriteLine($"{result}");
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
    public void TestRemoveMockUsers()
    {
        Arr usersBeforeRemoval = SQLQuery("SELECT email FROM users");

        var result = Utils.RemoveMockUsers();

        Arr usersAfterRemoval = SQLQuery("SELECT email FROM users");

        Assert.IsType<Arr>(result);
        foreach (var user in result)
        {
            Assert.False(user.HasKey("password"));
        }

        foreach (var user in mockUsers)
        {
            Assert.DoesNotContain(user.email, usersAfterRemoval.Map(u => u.email));
        }

        Assert.Equal(usersBeforeRemoval.Length - result.Length, usersAfterRemoval.Length);


        output.WriteLine($"{usersAfterRemoval}");

    }


}


    
