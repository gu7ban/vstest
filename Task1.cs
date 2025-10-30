using System;

public static class ExtensionMethods
{
    public static bool IsOdd(this int number)
    {
        return number % 2 != 0;
    }
    public static bool IsEven(this int number)
    {
        return number % 2 == 0;
    }
    public static bool IsContainsDigit(this string str)
    {
        foreach (char c in str)
        {
            if (char.IsDigit(c))
            {
                return true;
            }
        }
        return false;
    }
    public static string ToCapitalize(this string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        return char.ToUpper(str[0]) + str.Substring(1).ToLower();
    }

    public static int[] GetValueIndexes(this string str, char value)
    {
        int count = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == value)
            {
                count++;
            }
        }
        if (count == 0) return new int[0];
        int[] indexes = new int[count];
        int index = 0;
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == value)
            {
                indexes[index++] = i;
            }
        }

        return indexes;
    }
}

public class NewTask
{
    public static void Main()
    {
        int number = 5;
        Console.WriteLine($"{number} is odd: {number.IsOdd()}");
        Console.WriteLine($"{number} is even: {number.IsEven()}");

        string text = "Hello123";
        Console.WriteLine($"Does '{text}' contain digits: {text.IsContainsDigit()}");

        string name = "john";
        Console.WriteLine($"Capitalized: {name.ToCapitalize()}");

        string sentence = "Hello, world!";
        char searchChar = 'o';
        int[] indexes = sentence.GetValueIndexes(searchChar);
        Console.WriteLine($"Indexes of '{searchChar}' in '{sentence}': {string.Join(", ", indexes)}");
    }
}
