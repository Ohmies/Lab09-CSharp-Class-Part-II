Person.name = "Perapat Singpan";
System.Console.WriteLine(Person.Getname());

static class Person
{
    static public string name;
    static public string Getname()
    {

        return $"Hello from {name}";
    }
}