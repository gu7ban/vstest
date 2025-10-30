using System;
using System.Text.RegularExpressions;

public interface IAccount
{
    bool PasswordChecker(string password);
    void ShowInfo();
}

public class User : IAccount
{
    private static int _idCounter = 1;  
    private string _password;

    public int Id { get; private set; }
    public string Fullname { get; set; }
    public string Email { get; set; }

    public string Password
    {
        get => _password;
        set
        {
            if (PasswordChecker(value))
            {
                _password = value;
            }
            else
            {
                throw new ArgumentException("Şifre şertlere uygun deyil.");
            }
        }
    }
    public User(string email, string password)
    {
        Id = _idCounter++;
        Email = email;
        Password = password;
    }

    public bool PasswordChecker(string password)
    {
        if (password.Length < 8)
            return false;

        if (!Regex.IsMatch(password, @"[A-Z]"))
            return false;

        if (!Regex.IsMatch(password, @"[a-z]"))
            return false;

        if (!Regex.IsMatch(password, @"[0-9]")) 
            return false;

        return true;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"Id: "+Id);
        Console.WriteLine($"Fullname: "+Fullname);
        Console.WriteLine($"Email: "+Email);
    }
}

public class yenitask
{
    public static void Main()
    {
        try
        {
            User user1 = new User("eliveliyev@gmail.com", "pass4125");
            user1.Fullname = "Eli Veliyev";
            user1.ShowInfo();
            User user2 = new User("salam@gmail.com", "pass");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Xeta: {ex.Message}");
        }
    }
}
