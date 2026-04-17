string folder = "data";

if(!Directory.Exists(folder))
{
    Directory.CreateDirectory(folder);
}

string filepath = Path.Combine(folder, "file");
using (FileWriter writer = new(filepath))
{
    writer.Write("Hello, World!");
    writer.Write("Stream is writing!");
    writer.Write("Bye, World!");    
}


using(FileReader reader = new(filepath))
{
    Console.WriteLine(reader.Read(3));
}

Console.ReadKey();
