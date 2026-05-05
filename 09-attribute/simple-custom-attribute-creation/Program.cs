partial class Program
{   

    public static void Main(string[] args)
    {
            
        Type personType = typeof(Person);
        
        object[] attributes = personType.GetCustomAttributes(typeof(DeveloperAttribute), false);

        foreach (DeveloperAttribute item in attributes)
        {
            System.Console.WriteLine("Name: " + item.Name);
            System.Console.WriteLine("Version: " + item.Version);
        }
    }

    
}

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
class DeveloperAttribute : Attribute
{
    public string Name { get; set; }
    public string Version { get; set; } = "v1";

    public DeveloperAttribute(string name)
    {
        Name = name;
    }
}


[Developer("Hasib", Version = "v2")]
class Person
{
    public string Name { get; set; }
    public string Job { get; set; }
    
    public void DoJob()
    {
        System.Console.WriteLine("Doing Job...");
    }
}

