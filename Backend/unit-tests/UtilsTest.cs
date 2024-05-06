using Xunit;
using Xunit.Abstractions;

namespace WebApp;
public class UtilsTest
{
 
    // Note: You need to use the following command line command 
    // dotnet test --logger "console;verbosity=detailed"
    // for the logging to work
    private readonly ITestOutputHelper output;
    public UtilsTest(ITestOutputHelper output)
    {
        this.output = output;
    }


    /*
    [Fact]
    public void TestCreateMockUsers()
    {
        // Read all mock users from the JSON file
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);

        // Get all users from the database
        Arr usersInDb = SQLQuery("SELECT email FROM users");
        Arr emailsInDb = usersInDb.Map(user => user.email);

        // Only keep the mock users not already in db
        Arr mockUsersNotInDb = mockUsers.Filter(
            mockUser => !emailsInDb.Contains(mockUser.email)
        );

        // Get the result of running the method in our code
        var result = Utils.CreateMockUsers();
        // Assert that the CreateMockUsers only return
        // newly created users in the db
        output.WriteLine($"The test expected that {mockUsersNotInDb.Length} users should be added.");
        output.WriteLine($"And {result.Length} users were added.");
        output.WriteLine("The test also asserts that the users added " +
            "are equivalent (the same) to the expected users!");
        Assert.Equivalent(mockUsersNotInDb, result);
        output.WriteLine("The test passed!");
    }
    */


    /*
    [Fact]
    public void TestRemoveMockUsers()
    {
        var read = File.ReadAllText(FilePath("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);

        Arr usersBeforeRemoval = SQLQuery("SELECT email FROM users");

        // Get the result of running the method in our code
        var result = Utils.RemoveMockUsers();

        // Get all users from the database after removing mock users
        Arr usersAfterRemoval = SQLQuery("SELECT email FROM users");


        Assert.IsType<Arr>(result);
        foreach (var user in result)
        {
            Assert.False(user.HasKey("password"));
        }

        // Assert that only the mock users have been removed from the database
        foreach (var user in mockUsers)
        {
            Assert.DoesNotContain(user.email, usersAfterRemoval.Map(u => u.email));
        }

        Assert.Equal(usersBeforeRemoval.Length - result.Length, usersAfterRemoval.Length);


        output.WriteLine($"{usersAfterRemoval}");

    }
    /*




    /*
    [Fact]
    public void TestIsPasswordGoodEnough()
    {
        Assert.True(Utils.IsPasswordGoodEnough("Password1234!"));

        Assert.False(Utils.IsPasswordGoodEnough("Passwor"));

        Assert.False(Utils.IsPasswordGoodEnough("password1!"));

        Assert.False(Utils.IsPasswordGoodEnough("PASSWORD1!"));

        Assert.False(Utils.IsPasswordGoodEnough("Password!"));

        Assert.False(Utils.IsPasswordGoodEnough("Password1"));
    }
    */


    /*
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
    


}


    
