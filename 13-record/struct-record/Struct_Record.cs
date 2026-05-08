namespace RecordStruct;

class Program
{
    public record struct MutablePoint(int X, int Y);
    public readonly record struct ImmutablePoint(int X, int Y);

    static void Main()
    {
        Console.WriteLine("___Mutable Record Struct");
        MutablePoint p1 = new MutablePoint(10, 20);
        Console.WriteLine($"Original p1: {p1}");
        
        p1.X = 50; 
        p1.Y = 100;
        Console.WriteLine($"Modified p1: {p1}\n");

        Console.WriteLine("___Immutable Record Struct");
        ImmutablePoint p2 = new ImmutablePoint(10, 20);
        Console.WriteLine($"Original p2: {p2}");

        ImmutablePoint p3 = p2 with { X = 50 };
        Console.WriteLine($"Mutated p3 (New Copy): {p3}");
    }
}
