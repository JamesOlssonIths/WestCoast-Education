namespace WestCoast_Education;
using WestCoast_Education.InterFace;
using WestCoast_Education.Models;
using WestCoast_Education.Service;
class Program
{
    static void Main()
    {
        var school = new School();
        IntroMessages();
        switch (Console.ReadLine())
        {
            case"S":StudentServices.CreateNewStudent(school);
            break;
            case"E":EmployeeServices.CreateNewEmployee(school);
            break;
            case"C":ConsultentServices.CreateNewConsultant(school);
            break;

            default:break;
        }
    
      

        

        foreach (var item in school.Students)
        {
            System.Console.WriteLine(item.ToString());
        }
        foreach (var item in school.Employees)
        {
            System.Console.WriteLine(item.ToString());
        }
        foreach (var item in school.Consultants)
        {
            System.Console.WriteLine(item.ToString());
        }



    }

    static void IntroMessages()
    {
        System.Console.WriteLine("Pick S, E, C");
    }

}
