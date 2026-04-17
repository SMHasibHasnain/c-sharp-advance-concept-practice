class CsvReader : IDisposable
{
    private StreamReader _reader;

    public CsvReader(string filepath)
    {
        _reader = new(filepath);
    }

    public Csv Read()
    {
        string[] col = _reader.ReadLine().Split(",");
        List<string[]> rows = new();
        
        while(!_reader.EndOfStream)
        {
            var row = _reader.ReadLine().Split(",");
            rows.Add(row);
        }

        return new Csv
        {
            Columns = col,
            Rows = rows
        };

    } 

    public void Dispose()
    {
        _reader.Dispose();
    }
}