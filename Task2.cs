using System;

public interface IAccount
{
    bool PasswordChecker(string password);
    void ShowInfo();
}
public class User : IAccount
{
    private static int _idCounter = 4;
    private string _password;
    public readonly int Id;
    public string Fullname { get; set; }
    public string Email { get; set; }
    public string Password
    {
        set
        {
            if (PasswordChecker(value))
            {
                _password = value;
            }
            else
            {
                throw new ArgumentException("Sifre sertlere uygun deyil.");
            }
        }
    }
    public User(string email,string password)
    {
        Id = _idCounter++;
        Email = email;
        Password = password;
    }
public bool PasswordChecker(string password)
    {
        if(password.Length<8)
            return false;
        if (!password.Any(char.IsUpper))
            return false;
        if(!password.Any(char.IsLower))
            return false;
        if (!password.Any(char.IsDigit))
            return false;

        return true;
    }
    public void ShowInfo()
    {
        Console.WriteLine("Id: "+Id);
        Console.WriteLine("Fullname: "+Fullname);
        Console.WriteLine("Email: "+Email);
    }
}

public class Task2
{
    public static void Main()
    {
        try
        {
            User user1 = new User("mikayilehmedov@gmail.com", "Salam123");
            user1.Fullname = "Mikayil Ehmedov";
            user1.ShowInfo();

            User user2 = new User("malikzulfuqarov@gmail.com", "pass");
        }
        catch(ArgumentException ex)
        {
            Console.WriteLine("Xeta: " + ex.Message);
        }
    }
}