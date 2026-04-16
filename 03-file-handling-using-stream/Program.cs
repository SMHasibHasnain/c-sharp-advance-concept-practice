string folder = "data";

if(!Directory.Exists(folder))
{
    Directory.CreateDirectory(folder);
}

string filepath = Path.Combine(folder, "file");
FileWriter writer = new(filepath);

writer.Write("Hello, World!");
writer.Write("Stream is writing!");
writer.Write("Bye, World!");

Console.ReadKey();

class FileWriter
{
    private StreamWriter _writer;

    public FileWriter(string path)
    {
        _writer = new StreamWriter(path, true);        
    }

    public void Write(string text)
    {
        _writer.WriteLine(text);
        _writer.Flush();
    }
}