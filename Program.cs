namespace WestCoast_Education;
using WestCoast_Education.Models;
using WestCoast_Education.Service;
using WestCoast_Education.Services;

class Program
{
    static void Main()
    {
        while (true)
        {
            IntroMessages();
            switch (Console.ReadLine())
            {
                case"Student":StudentServices.CreateNew();
                break;
                case"Show Student": StudentServices.PrintAll();
                break;
                case"Ed":EducationSupervisorServices.CreateNew();
                break;
                case"Show Ed":EducationSupervisorServices.PrintAll();
                break;
                case"Teacher":TeacherServices.CreateNew();
                break;
                case"Show Teacher": TeacherServices.PrintAll();
                break;
                case"CA": AdministratorServices.CreateNew();
                break;
                case"SA":AdministratorServices.PrintAll();
                break;
                case"Course":CourseServices.CreateNewCourse();
                break;
                case"Show Course": var course = CourseServices.GetCourses();
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
        System.Console.WriteLine("Pick Student(Create student), ED(Create Education Supervisor), Teacher(Create Teacher), Show Student(show Students), Show Ed(Show employees), Show Teacher(Show consultant) Course(Create course) Show Course(Show Course) CA (Create Administorator) SA(show Adminsitators) To exit program enter 'x'");
    }

}
