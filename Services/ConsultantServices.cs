using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class ConsultentServices
{
    public static void CreateNewConsultant()
    {
        var consultant = new Consultant
        {
          FirstName=CheckInput("First name"),  
          LastName=CheckInput("Last name"),  
          PhoneNumber=CheckInput("Phone number"),  
          SocialSecurityNumber=CheckInput("Social Security Number"),  
          Address=CheckInput("Address"),  
          CityNumber=CheckInput("CityNumber"),  
          City=CheckInput("City"),
          KnowledgeArea=CheckInput("Knowledge area"),
          Courses=CheckInput("Active course")

        };

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
