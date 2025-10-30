using System;

public class Student
{
    private static int _idCounter = 1;
    public int Id { get; }
    public string Fullname { get; }
    public double Point { get; }

    public Student(string fullname, double point)
    {
        if (string.IsNullOrEmpty(fullname))
        {
            throw new ArgumentException("Fullname cannot be null or empty.");
        }
        if (point < 0 || point > 100)
        {
            throw new ArgumentOutOfRangeException("Point must be between 0 and 100.");
        }

        Id = _idCounter++;
        Fullname = fullname;
        Point = point;
    }
    public void StudentInfo()
    {
        Console.WriteLine($"Id: {Id} | Fullname: {Fullname} | Point: {Point}");
    }
}

public class Task3
{
    public static void Main()
    {
        try
        {
            var student1 = new Student("Celal Abbasov", 65);
            var student2 = new Student("Abbas Elekberov", 78);
            var student3 = new Student("Mehdi Firuddinzade", 96);
            student1.StudentInfo();
            student2.StudentInfo();
            student3.StudentInfo();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}