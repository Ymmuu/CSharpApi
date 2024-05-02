using Xunit;
namespace WebApp;

public class UtilsTest
{

    /*
    [Fact]
    public void TestCreateMockUsers()
    {
        // Read all mock-users from JSON file
        var read = File.ReadAllText(Path.Combine("json", "mock-users.json"));
        Arr mockUsers = JSON.Parse(read);
        /*
        foreach(var user in mockUsers)
        {
            //Log(user);
        }
        

        // Get all users from DB
        Arr usersInDb = SQLQuery("SELECT email FROM users");
        Arr emailIsInDb = usersInDb.Map(user => user.email);
        // Only keep the mock users not already in DB
        Arr mockUsersNotInDb = mockUsers.Filter(mockUser => !emailIsInDb.Contains(mockUser.email));
        //Asserts that the CreateMockUsers only return newly created users in the db
        var result = Utils.CreateMockUsers();

        //Log("calculated by test", mockUsersNotInDb);
        //Log("reported by method", result);

        // Assert the same length
        Assert.Equal(mockUsersNotInDb.Length, result.Length);
    }
    */

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


    [Fact]
    public void TestRemoveBadWords()
    {
        var read = File.ReadAllText(Path.Combine("json", "bad-words.json"));
        Arr badWords = JSON.Parse(read);

        var input = "Hello. This is a test sentence with fuck, hell and shit.";
    
        var expectedOutput = "Hello. This is a test sentence with ****, **** and ****.";

        var result = Utils.RemoveBadWords(input, "****");

        Assert.Equal(expectedOutput, result);
    }


}
