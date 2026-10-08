namespace WestCoast_Education;
using WestCoast_Education.InterFace;
using WestCoast_Education.Models;
class Program
{
    static void Main()
    {
        var school = new School();

       // var james = new Student { FirstName = "James" };
        // var helder = new Employee { FirstName = "Helder" };

        // school.AddStudent(james);
        // school.AddEmployee(helder);

        // Console.WriteLine("--- Students ---");
        // foreach (var student in school.Students)
        // {
        //     Console.WriteLine(student);
            
        // }

        // Console.WriteLine("--- Employees ---");
        // foreach (var employee in school.Employees)
        // {
        //     Console.WriteLine(employee);
            
        // }

    }

    static void CreateNewStudent()
    {
        var james = new Student
        {
          FirstName="",  
          LastName="",  
          PhoneNumber="",  
          SocialSecurityNumber="",  
          Address="",  
          CityNumber="",  
          City="",  
        };


    }


}
