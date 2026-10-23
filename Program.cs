namespace WestCoast_Education;
using WestCoast_Education.Models;
using WestCoast_Education.Service;
class Program
{
    static void Main()
    {
        while (true)
        {
            IntroMessages();
            switch (Console.ReadLine())
            {
                case"S":StudentServices.CreateNew();
                break;
                case"SP": StudentServices.PrintAll();
                break;
                case"E":EducationSupervisorServices.CreateNew();
                break;
                case"EP":EducationSupervisorServices.PrintAll();
                break;
                case"C":TeacherServices.CreateNew();
                break;
                case"CP": TeacherServices.PrintAll();
                break;
                case"CO":TeacherServices.CreateNew();
                break;
                case"Course":CourseServices.CreateNewCourse();
                break;
                case"Scourse": var course = CourseServices.GetCourses();
                foreach (var item in course)
                {
                    Console.WriteLine(item.ToString());
                }
                break;
                default:break;
            }
        }
    }
    static void IntroMessages()
    {
        System.Console.WriteLine("Pick S(Create student), E(Create Employee), C(Create Consultant), SP(show Students), EP(Show employees), CP(Show consultant)");
    }

}
