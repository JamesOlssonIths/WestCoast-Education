using System.Dynamic;
using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class StudentServices
{
    

    public static void CreateNewStudent(School school)
    {
        string path = string.Concat(Environment.CurrentDirectory,"/Data/Student.json");
        var storage = new Storage<Student>();

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

        var students = GetStudents();
        students.Add(student);

        storage.Write(path, students);

    }

    static string CheckInput(string Question)
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

    public static List<Student> GetStudents()
    {
        string path = string.Concat(Environment.CurrentDirectory,"/Data/Student.json");
        var storage = new Storage<Student>();
        
        
        return storage.Read(path);
    }




}
