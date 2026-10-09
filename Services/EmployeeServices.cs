using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class EmployeeServices
{
    public static void CreateNewEmployee(School school)
    {
        var employee = new Employee
        {
          FirstName=CheckInput("First name"),  
          LastName=CheckInput("Last name"),  
          PhoneNumber=CheckInput("Phone number"),  
          SocialSecurityNumber=CheckInput("Social Security Number"),  
          Address=CheckInput("Address"),  
          CityNumber=CheckInput("CityNumber"),  
          City=CheckInput("City"),
          StartOfEmplyoment=CheckInput("Start of employment") 
        };
        school.AddStudent(employee);

    }

    static string CheckInput(string Question)
    {
        System.Console.Write($"Enter your {Question}: ");
        var userInput =Console.ReadLine();
        while(string.IsNullOrWhiteSpace(userInput))
        {
            System.Console.WriteLine("Please enter something vaild");
        }

        return userInput;
    }

}
