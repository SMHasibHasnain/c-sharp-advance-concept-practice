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