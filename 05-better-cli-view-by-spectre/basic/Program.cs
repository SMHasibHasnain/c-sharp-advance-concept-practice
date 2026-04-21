
using System.Collections;
using Spectre.Console;

AnsiConsole.MarkupLine("Welcome To [bold green]Ftruit Vallay![/]");


CsvFileReader csvFile = new CsvFileReader();
var alldata = csvFile.Read();

var india_fruits = alldata.rows.Where(row => row[3] == "India").ToList();

var table = new Table();

foreach(var item in alldata.header!)
{
    table.AddColumn(item);
}


var list = new List<string>();
foreach (var rows in india_fruits)
{
    list.Clear();
    foreach (var rowData in rows)
    {
        list.Add(rowData);
    }
    table.AddRow(list.ToArray());
}


AnsiConsole.Write(table);

Console.ReadKey();

class CsvFileFormat
{
    public string[]? header;
    public List<string[]>? rows;
}

class CsvFileReader
{
    public CsvFileFormat Read()
    {
        StreamReader stream = new StreamReader("fruits_dataset.csv");

        CsvFileFormat csvFile = new CsvFileFormat();

        csvFile.header = stream.ReadLine()?.Split(",");

        csvFile.rows = new();

        while(!stream.EndOfStream)
        {
            csvFile?.rows?.Add(stream.ReadLine()!.Split(","));
        }

        return csvFile!;
    }
}