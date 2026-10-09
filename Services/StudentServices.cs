using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class StudentServices
{
    
    

    public static void CreateNewStudent(School school)
    {
        string path = string.Concat(Environment.CurrentDirectory,"/Data/Student.json");

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
        var storage = new Storage<Student>();
        storage.Write(path, school.Students);

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

    public static List<Student> GetStudents()
    {
        string path = string.Concat(Environment.CurrentDirectory,"/Data/Student.json");
        var storage = new Storage<Student>();
        return storage.Read(path);
    }




}
