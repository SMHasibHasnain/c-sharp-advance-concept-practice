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
