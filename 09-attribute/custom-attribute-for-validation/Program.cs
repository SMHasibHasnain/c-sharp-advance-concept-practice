[AttributeUsage(AttributeTargets.Property)]
public class NameLengthMoreThanAttribute : Attribute
{
    public int Length { get; set; }
    
    public NameLengthMoreThanAttribute (int length) {
        Length = length;
    }
}

public class Student
{
    [NameLengthMoreThan(8)]
    public string? Name { get; set; } 

    public Student(string name)
    {
        Name = name;
    }   
}

public class Employee
{
    [NameLengthMoreThan(10)]
    public string? Name { get; set; }

    public Employee(string name)
    {
        Name = name;
    }       
}

public class BusinessMan
{
    [NameLengthMoreThan(5)]
    public string? Name { get; set; }

    public BusinessMan(string name)
    {
        Name = name;
    }       
}

public class Validation
{
    public static bool Validator(object obj)
    {
        var properties = obj.GetType().GetProperties()
            .Where( p => Attribute.IsDefined(p, typeof(NameLengthMoreThanAttribute)));
        
        foreach (var prop in properties)
        {
            var value = (string)prop.GetValue(obj); 
            var attr = (NameLengthMoreThanAttribute)prop.GetCustomAttributes(typeof(NameLengthMoreThanAttribute), false).First();

            if (string.IsNullOrEmpty(value) || value.Length < attr.Length)
            {
                return false; 
            }
        }
        
        return true;
    }
}

public class Execute
{
    public static void Main(string[] args)
    {
        var student = new Student("Hasib Hasnain");
        var employee = new Employee("Hasnain");
        var businessMan = new BusinessMan("Hasib");

        Console.WriteLine("Is student's name valid? " + Validation.Validator(student));
        Console.WriteLine("Is employee's name valid? " + Validation.Validator(employee));
        Console.WriteLine("Is business man's name valid? " + Validation.Validator(businessMan));                
    }
}