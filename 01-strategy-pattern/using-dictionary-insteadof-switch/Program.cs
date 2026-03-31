// Data
var list = new List<int>
{
    2, 3, 10, 32, 12, 44, 1, -5, -33, 22, 55, -9, 99, 66
};


// Dictionary contains commands & Funcs
var dictionary = new Dictionary<string, Func<int, bool>>
{
    ["even"] = num => num % 2 == 0,
    ["odd"] = num => num % 2 != 0,
    ["positive"] = num => num > 0,
    ["negative"] = num => num < 0
};


// Show commands
Console.WriteLine("Available operations: ");
foreach (var item in dictionary)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.ForegroundColor = ConsoleColor.Black;
    Console.Write(item.Key);
    Console.ResetColor();
    Console.Write(" ");
}


// Take user inputs
Console.WriteLine();
Console.Write("Enter your choice: ");
var choice = Console.ReadLine();
Console.WriteLine();


// Analyze inputs and map to the dictionary commands
List<int> result;
if(dictionary.ContainsKey(choice!))
{
    result = FilterBy(list, dictionary[choice!]);
} else
{
    throw new NotSupportedException();
}


// Print result
foreach(var item in result)
{
    Console.Write(item + " ");
}
Console.WriteLine();
Console.ReadKey();


// Function that taking list and Func
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




