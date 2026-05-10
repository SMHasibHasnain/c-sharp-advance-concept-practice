namespace _15_api_basic;

public class Uri_Test
{
    public static void Main(string[] args)
    {
        Uri uri = new Uri("https://google.com/search?q=csharp");
        System.Console.WriteLine("Scheme: " + uri.Scheme);
        System.Console.WriteLine("Host: " + uri.Host);
        System.Console.WriteLine("Abs Path: " + uri.AbsolutePath);
        System.Console.WriteLine("Query: " + uri.Query);
        System.Console.WriteLine("DnsSafeHost: " + uri.DnsSafeHost);
        System.Console.WriteLine("Authority: " + uri.Authority);
        System.Console.WriteLine("AbsoluteUri: " + uri.AbsoluteUri);
        System.Console.WriteLine("Port: " + uri.Port);
         
    }
}
