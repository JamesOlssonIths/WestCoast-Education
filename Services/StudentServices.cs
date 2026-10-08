using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class StudentServices
{
    public static void CreateNewStudent(School school)
    {
        var student = new Student
        {
          FirstName=CheckInput("First name"),  
          LastName=CheckInput("Last name"),  
          PhoneNumber=CheckInput("Phone number"),  
          SocialSecurityNumber=CheckInput("Social Security Number"),  
          Address=CheckInput("Address"),  
          CityNumber=CheckInput("CityNumber"),  
          City=CheckInput("City") 
        };
        school.AddStudent(student);

    }

    static string CheckInput(string Question)
    {
        System.Console.WriteLine($"Enter {Question}");
        var userInput =Console.ReadLine();
        while(string.IsNullOrWhiteSpace(userInput))
        {
            System.Console.WriteLine("Please enter something vaild");
        }

        return userInput;
    }


}
