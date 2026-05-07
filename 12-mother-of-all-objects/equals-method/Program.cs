namespace EqualsMethod

{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }


    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    class Program
    {
        static void Main()
        {
            Console.WriteLine("--- 1. Simple Types ---");
            Console.WriteLine($"1 Equals 1: {1.Equals(1)}"); // True
            Console.WriteLine($"1 Equals 2: {1.Equals(2)}"); // False
            Console.WriteLine($"'ABC' Equals 'ABC': {"ABC".Equals("ABC")}"); // True
            Console.WriteLine();

            Console.WriteLine("--- 2. Reference Type (Class) ---");
            Person p1 = new Person { Name = "Hasib", Age = 24 };
            Person p2 = new Person { Name = "Hasib", Age = 24 };

            Person p3 = p1; 

            Console.WriteLine($"p1 Equals p2 (Different instances, same data): {p1.Equals(p2)}"); // False
            Console.WriteLine($"p1 Equals p3 (Same instance): {p1.Equals(p3)}"); // True
            Console.WriteLine();

            Console.WriteLine("--- 3. Value Type (Struct) ---");
            Point point1 = new Point { X = 10, Y = 20 };
            Point point2 = new Point { X = 10, Y = 20 };

            Console.WriteLine($"point1 Equals point2 (Different variables, same data): {point1.Equals(point2)}"); //True

            Console.WriteLine("--- 4. Value Type using IEquatable ---");
            Student s1 = new Student { Name = "Hasib", Age = 24 };
            Student s2 = new Student { Name = "Hasib", Age = 24 };

            Console.WriteLine($"s1 Equals s2 (Different variables, same data): {point1.Equals(point2)}"); //True

        }
    }

    public struct Student : IEquatable<Student>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public bool Equals(Student other)
        {
            return Name.Equals(other.Name) && Age.Equals(other.Age);
        }

        public override bool Equals(object? obj)
        {
            if(obj is Student student) return Equals(student);
            else return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Age);
        }

        public static bool operator ==(Student left, Student right)
        {
            return left.Equals(right);
        }

        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }       
    }
}