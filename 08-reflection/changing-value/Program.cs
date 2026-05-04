
using System.Reflection;

Type personType = typeof(Person);

Object person = Activator.CreateInstance(personType)!;

PropertyInfo id = personType.GetProperty("Id")!;
id.SetValue(person, Guid.CreateVersion7());

PropertyInfo name = personType.GetProperty("Name")!;
name.SetValue(person, "Hasib");

PropertyInfo job = personType.GetProperty("Job")!;
job.SetValue(person, "Software Engineer");

PropertyInfo salary = personType.GetProperty("Salary")!;
salary.SetValue(person, 400000m);

FieldInfo nmbr = personType.GetField("_mobileNumber", BindingFlags.NonPublic | BindingFlags.Instance)!;
nmbr.SetValue(person, "01312345678");

MethodInfo method = personType.GetMethod("PersonInfo")!;
method.Invoke(person, null);



class Person
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? Job { get; set; }
    public decimal Salary {get; init; }
    private string? _mobileNumber;

    public void PersonInfo()
    {
        System.Console.WriteLine($"{Name} ({Id}) is working as a {Job}. His Salary is {Salary}tk. His mobile number is {_mobileNumber}.");
    }
}
