using System.Data;

public record Person (string Name, string Hometown);

class Program
{
    public static void Main(string[] args)
    {
        Person person1 = new Person("Hasib", "Pabna");
        Person person2 = new Person("Mofij", "Sirajgonj");

        Person person3 = new Person("Hasib", "Pabna");
        
        Console.WriteLine("Is person1, person2 equal? => " + person1.Equals(person2)); // False
        Console.WriteLine("Is person1, person3 equal? => " + person1.Equals(person3)); // True
        Console.WriteLine("Is person1, person3 equal? => " + (person1 == person3)); // True
        
        Console.WriteLine(person1.ToString()); //Person { Name = Hasib, Hometown = Pabna }

        

    } 
}