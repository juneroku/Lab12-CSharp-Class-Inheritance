using System;

class Person
{
    private string name = string.Empty;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}

class Student : Person
{
    // Student class inherits from Person, so it can use Name property directly.
}

class Program
{
    static void Main()
    {
        Student student1 = new Student();
        student1.Name = "Somchai";
        Console.WriteLine($"student1 name = {student1.Name}");

        var student2 = new Student();
        student2.Name = "Sompong";
        Console.WriteLine($"student2 name = {student2.Name}");
    }
}
