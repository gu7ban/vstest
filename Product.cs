using System;

class Student
{
    public string FullName { get; set; }
    public string GroupNo { get; set; }
    public int AvgPoint { get; set; }
    public Student(string fullName)
    {
        if (string.IsNullOrEmpty(fullName))
        {
            Console.WriteLine("Fullname teyin olunmalidir!");
        }
        FullName = fullName;
    }

}