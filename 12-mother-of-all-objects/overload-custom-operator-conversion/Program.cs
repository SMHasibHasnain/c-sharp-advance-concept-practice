using System.Security.Cryptography.X509Certificates;

namespace overload_custom_operator_conversion;


public class Program
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("---Tuple to Struct (Implicit)---");
        var infoOfPerson1 = ("Hasib", 45);
        Person person1 = infoOfPerson1;
        System.Console.WriteLine(person1);

        System.Console.WriteLine("---Struct to Tuple (Implicit)---");
        var person2 = new Person("Shakib Khan", 80);
        var infoOfPerson2 = (person2.Name, person2.Age);
        System.Console.WriteLine(infoOfPerson2);
    }
}

public struct Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public static implicit operator Person ((string x, int y) tuple)
    {
        return new Person(tuple.x, tuple.y);
    }

    public static implicit operator (string x, int y) (Person person)
    {
        return (person.Name, person.Age);
    }    

    public override string ToString()
    {
        return $"Name: {Name}\nAge: {Age}";
    }
}



