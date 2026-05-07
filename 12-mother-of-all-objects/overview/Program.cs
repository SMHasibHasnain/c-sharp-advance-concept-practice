var student1 = new Student("Hasib", 10);
var student2 = new Student("Rahim", 13);
var student3 = new Student("Hasib", 10);

Student DuplicateStudent = student1;

var num1 = 23;
var num2 = 23;

Student student4;

System.Console.WriteLine("ToString() => " + student1.ToString());
System.Console.WriteLine("GetType().Name => " + student1.GetType().Name);
System.Console.WriteLine("student1 equals student2? => " + student1.Equals(student2));
System.Console.WriteLine("student1 referenceEquals student2? => " + object.ReferenceEquals(student1, student2));
System.Console.WriteLine("num1 refEql num2? => " + object.ReferenceEquals(num1, num2)); //it uses boxing
System.Console.WriteLine("student1 referenceEquals student3? => " + object.ReferenceEquals(student1, student3));
System.Console.WriteLine("student1 referenceEquals  DuplicateStudent? => " + object.ReferenceEquals(student1, DuplicateStudent));




class Student
{
    public string? Name { get; set; }
    public int Roll { get; set; }

    public Student(string name, int roll)
    {
        Name = name;
        Roll = roll;
    }

}