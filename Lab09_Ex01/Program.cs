Person.name = "OHM";
System.Console.WriteLine(Person.Getname());

static class Person
{
    public static string name;
    public static string Getname()
    {
        return $"Hello from {name}";
    }
}