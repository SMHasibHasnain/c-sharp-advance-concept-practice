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

class FileWriter : IDisposable
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

    public void Dispose()
    {
        _writer.Dispose();
    }
}

class FileReader : IDisposable
{
    private StreamReader _reader;
    public FileReader(string path)
    {
        _reader = new StreamReader(path);
    }


    //Causing Exception, Because StreamWriter is holding the file or locking the file. So, disposable interface using is worthy!
    public string Read(int lineNumber)
    {
        _reader.DiscardBufferedData();
        _reader.BaseStream.Seek(0, SeekOrigin.Begin);

        for(int i=0; i<lineNumber - 1; i++)
        {
            _reader.ReadLine();
        }

        return _reader.ReadLine();
    }

    public void Dispose()
    {
        _reader.Dispose();
    }
}