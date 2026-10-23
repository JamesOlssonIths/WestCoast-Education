namespace WestCoast_Education.Models;
using System.Collections.Generic;

public class InputServices
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


    public static T UserInputForCreation<T>() where T : Person, new()   
    {
        var person = new T
        { 
            FirstName = CheckInput("First name"),
            LastName = CheckInput("Last name"),
            PhoneNumber = CheckInput("Phone number"),
            SocialSecurityNumber = CheckInput("Social Security Number"),
            Address = new Address
            {
                Street = CheckInput("street address"),
                PostalCode = CheckInput("postal code"),
                City = CheckInput("city")
            }
        };
        return person;
    }

    public static int AskForInt(string question)
    {
        while (true)
        {
            var Userinput = CheckInput(question);
            if (int.TryParse(Userinput, out var result))
                return result;

            Console.WriteLine("Please enter a valid number.");
        }
    }
    public static bool AskForBool(string question)
    {
        while (true)
        {
            var input = CheckInput(question);
            if (input is "y") return true;
            if (input is "n")  return false;

            Console.WriteLine("Please answer y or n.");
        }
    }
    public static DateTime AskForDate(string question)
    {
        while (true)
        {
            var input = CheckInput(question);
            if (DateTime.TryParse(input, out var result))
                return result;

            Console.WriteLine("Please enter a valid date, e.g. 2026-11-01.");
        }
    }

}
