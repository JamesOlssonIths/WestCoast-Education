namespace WestCoast_Education.Models;
using System.Collections.Generic;

public class InputSerivces
{
    public static string CheckInput(string Question)
    {
        System.Console.Write($"Enter your {Question}: ");
        var userInput =Console.ReadLine();
        while(string.IsNullOrWhiteSpace(userInput))
        {
            System.Console.WriteLine("Please enter something valid");
            System.Console.Write($"Enter your {Question}: ");
            userInput = Console.ReadLine();
        }

        return userInput;
    }


    public static T UserInputForCreation<T>() where T : Person, new()   //https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/types/generics
    {
        var person = new T
        { 
            FirstName = CheckInput("First name"),
            LastName = CheckInput("Last name"),
            PhoneNumber = CheckInput("Phone number"),
            SocialSecurityNumber = CheckInput("Social Security Number"),
            Address = CheckInput("Address"),
            CityNumber = CheckInput("CityNumber"),
            City = CheckInput("City")
        };
        return person;
    }

}
