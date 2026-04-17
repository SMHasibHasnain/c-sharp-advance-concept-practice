string filepath = Path.Combine("_data", "color_srgb.csv");

if(!File.Exists(filepath))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("'color_srgb.csv' File not found!");
    Console.ResetColor();
    return;
}

using CsvReader csvReader = new(filepath);
Csv csvdata = csvReader.Read();

Console.WriteLine(new string('-', 45));

foreach(var item in csvdata.Columns)
{
    Console.Write($"{item, -12}");
}

Console.WriteLine();
Console.WriteLine(new string('-', 45));

foreach (string[] row in csvdata.Rows)
{
    foreach (var item in row)
    {
        Console.Write($"{item, -10} ");
    }
    Console.WriteLine();
}

Console.WriteLine(new string('-', 45));
