namespace NullableTypes;

class Program
{
    static void Main()
    {
        int? nullableInt = null; 
        Nullable<int> anotherNullableInt = new Nullable<int>(); 

        int? someNumber = 50;
        if (someNumber.HasValue)
        {
            Console.WriteLine($"The value is: {someNumber.Value}");
        }

        int? missingNumber = null;
        
        try
        {
            int crashNumber = missingNumber.Value; // Error
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Exception Caught: {ex.Message}"); 
        }

        int? randomNullablePeopleAge = null;
        //int age = randomPeopleAge.Value; Error

        //Basic Way
        int Age;
        if(randomNullablePeopleAge.HasValue) Age = randomNullablePeopleAge.Value;

        int BetterWayToPutAge = randomNullablePeopleAge ?? 18; //Null-Coalescing Operator


        //Smart way to unpack nullable operator
        if(randomNullablePeopleAge is int boyosh) System.Console.WriteLine(boyosh);
    }

}
