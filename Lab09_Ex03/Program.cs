Person.name = "Perapat Singpan";
System.Console.WriteLine(Person.Getname());
var student = new Student();
Student.name = "Perapat Singpan";
System.Console.WriteLine(student.Getname());

static class Person
{
    static public string name;
    static public string Getname()
    {
        return $"Hello from {name}";
    }
}

class Student
{
    public static string name;
    public string Getname()
    {
        return $"Hello from {name}";
    }
}