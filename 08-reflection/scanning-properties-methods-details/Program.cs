using System.Reflection;

partial class Program
{
    static void Main()
    {
        Type studentType = typeof(Student);
        var properties = studentType.GetProperties(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        var methods = studentType.GetMethods();

        Console.Clear();

        //class name
        System.Console.WriteLine("Class Name: " + studentType.Assembly);
        System.Console.WriteLine();

        //properties
        System.Console.WriteLine("Properties: ");
        foreach (var item in properties)
        {
            System.Console.WriteLine($"{item.Name} : {item.PropertyType.Name}");
        }
        System.Console.WriteLine();

        //methods
        System.Console.Write("Methods: ");
        foreach (var item in methods)
        {
            System.Console.WriteLine();

            System.Console.WriteLine($"{item.Name} : {item.ReturnType.Name}");

            var parameters = item.GetParameters();
            if(!parameters.Any()) continue;
            
            //methods parameters
            System.Console.WriteLine("    Parameters: ");
            foreach (var param in parameters)
            {
                System.Console.WriteLine("    - " + param.Name + $"({param.ParameterType.Name})");
            }
        }
    }
}

class Student
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Class { get; set; }
    public DateOnly RegDate {get; init; }
    private string _mobileNumber;

    public void result()
    {
        
    }
}
