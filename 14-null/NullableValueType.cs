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

        int? randomPeopleAge = null;
        //int age = randomPeopleAge.Value; Error

        //Basic Way
        int Age;
        if(randomPeopleAge.HasValue) Age = randomPeopleAge.Value;

        int BetterWayToPutAge = randomPeopleAge ?? 18; //Null-Coalescing Operator
    }

}
