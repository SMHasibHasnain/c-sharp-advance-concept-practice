using System;

namespace NullableReferenceTypesDemo
{
    public class Address
    {
        // Non-nullable reference types. 
        public string Street { get; set; }
        public string Number { get; set; }
        public string? ApartmentNumber { get; set; }

        public Address(string street, string number)
        {
            ArgumentNullException.ThrowIfNull(street);
            ArgumentNullException.ThrowIfNull(number);

            Street = street;
            Number = number;
        }
    }

    public class House
    {
        public string OwnerName { get; set; }
        public Address HouseAddress { get; set; }

        public House(string ownerName, Address houseAddress)
        {
            ArgumentNullException.ThrowIfNull(ownerName);
            ArgumentNullException.ThrowIfNull(houseAddress);

            OwnerName = ownerName;
            HouseAddress = houseAddress;
        }

        public string GetHouseInfo()
        {
            return $"{OwnerName} lives at {HouseAddress.Street}, {HouseAddress.Number}";
        }
    }

    class Program
    {
        static void Main()
        { 
            string nonNullableString = "Hasib";

            string? nullableString = null; 
            if (nullableString != null)
            {
                Console.WriteLine(nullableString.Length); 
            }

            string[] nonNullableArray = new string[5]; 
            
            try
            {
                Console.WriteLine(nonNullableArray[0].Length); 
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Exception! IDE couldn't save us from the array blindspot.");
            }
        }
    }
}