Action<string> action = Greet("Hello");

action();

static oid Greet(string greet)
{
    System.Console.WriteLine(greet);    
}