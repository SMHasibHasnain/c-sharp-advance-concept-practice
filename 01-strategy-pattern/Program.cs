using System.Transactions;

var list = new List<int>
{
    2, 3, 10, 32, 12, 44, 1, -5, -33, 22, 55, -9, 99, 66
};

var dictionary = new Dictionary<string, Func<int, bool>>
{
    ["even"] = num => num % 2 == 0,
    ["odd"] = num => num % 2 != 0,
    ["positive"] = num => num > 0,
    ["negative"] = num => num < 0
};

Console.WriteLine("Available operations: ");
foreach (var item in dictionary)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(item.Key);
    Console.ResetColor();
    Console.Write(" ");
}

Console.WriteLine();
Console.Write("Enter your choice: ");
var choice = Console.ReadLine();
Console.WriteLine();

List<int> result;

if(dictionary.ContainsKey(choice!))
{
    result = FilterBy(list, dictionary[choice!]);
} else
{
    throw new InvalidOperationException();
}

foreach(var item in result)
{
    Console.Write(item + " ");
}

Console.WriteLine();
Console.ReadKey();

List<int> FilterBy(List<int> list, Func<int, bool> predicate)
{
    var resultList = new List<int>();
    foreach(var item in list)
    {
        if(predicate(item))
        {
            resultList.Add(item);
        }
    }
    return resultList;
}