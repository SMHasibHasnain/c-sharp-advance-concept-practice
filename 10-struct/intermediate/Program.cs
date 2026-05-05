using System.Security.Cryptography.X509Certificates;

readonly struct Axios
{
    public int X { get; init; }
    public int Y { get; init; }
    public int Z { get; init; }

    public Axios (int x, int y, int z)
    {
        X = x;
        Y = y;
        Z = z;
    }
}

class Run
{
    public static void Main(String[] args)
    {
        Axios one = new Axios(4, 2, 6);
        Axios two = one with { X = 5, Y = 3, Z = 7 };

        Console.WriteLine("Previous: ");
        Console.WriteLine("X: " + one.X);
        Console.WriteLine("Y: " + one.Y);
        Console.WriteLine("Z: " + one.Z);

        Console.WriteLine("New: ");
        Console.WriteLine("X: " + two.X);
        Console.WriteLine("Y: " + two.Y);
        Console.WriteLine("Z: " + two.Z);        
    }
}