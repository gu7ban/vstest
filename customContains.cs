using System;

public static class StringExtensions
{
    public static bool CustomContains(this string source, string searchTerm)
    {
        string sourceLower = source.ToLower();
        string searchTermLower = searchTerm.ToLower();
        int sourceLength = sourceLower.Length;
        int searchTermLength = searchTermLower.Length;
        for (int i = 0; i <= sourceLength - searchTermLength; i++)
        {
            bool matchFound = true;
            for (int j = 0; j < searchTermLength; j++)
            {
                if (sourceLower[i + j] != searchTermLower[j])
                {
                    matchFound = false;
                    break;
                }
            }
            if (matchFound)
            {
                return true;
            }
        }
        return false;
    }
}

class customContains
{
    static void Main()
    {
        string sampleSentence = "Bu bir custom contains methodudur";

        Console.WriteLine($"\"Bu\" axtaris neticesi: "+sampleSentence.CustomContains("Bu"));
        Console.WriteLine($"\"bu\" axtaris neticesi: "+sampleSentence.CustomContains("bu"));
        Console.WriteLine($"\"tains\" axtaris neticesi: "+sampleSentence.CustomContains("tains"));
        Console.WriteLine($"\"ns Methodudur\" axtaris neticesi:"+sampleSentence.CustomContains("ns Methodudur"));
        Console.WriteLine($"\"bu bir custom\" axtaris neticesi:" +sampleSentence.CustomContains("bu bir custom"));
    }
}
