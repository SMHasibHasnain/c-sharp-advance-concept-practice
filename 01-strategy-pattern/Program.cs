var list = new List<int>
{
    2, 3, 10, 32, 12, 44, 1, -5, -33, 22, 55, -9, 99, 66
};



var choice = Console.ReadLine();
List<int> result;
switch(choice)
{
    case "even" :
        result = FilterBy(list, num => num % 2 == 0);
        break;
    case "odd" :
        result = FilterBy(list, num => num % 2 != 0);
        break;
    case "possive" :
        result = FilterBy(list, num => num > 0);
        break;
    case "negative" :
        result = FilterBy(list, num => num < 0);
        break;
    default:
        result = null!;
        Console.WriteLine("Wrong Input!");
        break;                      
}


foreach(var item in result)
{
    Console.Write(item + " ");
}


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