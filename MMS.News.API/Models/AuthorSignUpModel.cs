namespace MMS.News.API.Models;

public class AuthorSignUpModel
{
    public AuthorSignUpModel(string firstName, string lastName, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string Password { get; }
}