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
            Console.WriteLine("Xeta: Fullname bos ola bilmez.");
            return;
        }
        if(point < 0 || point > 100)
        {
            Console.WriteLine("Xeta: Point 0 ile 100 arasinda olmalidir.");
            return ;
        }
        Id=_idCounter++;
        Fullname=fullname;
        Point=point;
    }
    public void StudentInfo()
    {
        Console.WriteLine("Id: "+Id+" Fullname: "+Fullname+" Point: "+Point);
    }
}
public class Task3
{
    public static void Main()
    {
        var student1 = new Student("Celal Abbasov", 65);

        var student2 = new Student("Abbas Elekberov", 78);

        var student3 = new Student("Mehdi Firuddinzade", 96);
    }
}