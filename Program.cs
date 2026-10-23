namespace WestCoast_Education;
using WestCoast_Education.InterFace;
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
                case"S":StudentServices.CreateNewStudent();
                break;
                case"SP":var students = StudentServices.GetStudents();
                    foreach (var item in students)
                    {
                        Console.WriteLine(item.ToString());
                    }
                break;
                case"E":EmployeeServices.CreateNewEmployee();
                break;
                case"EP":var employee = EmployeeServices.GetEmployee();
                    foreach (var item in employee)
                    {
                        Console.WriteLine(item.ToString());
                    }
                break;

                case"C":ConsultentServices.CreateNewConsultant();
                break;
                case"CP": var consultant = ConsultentServices.GetConsultant();
                 foreach (var item in consultant)
                    {
                        Console.WriteLine(item.ToString());
                    }
                break;
                case"CO":ConsultentServices.CreateNewConsultant();
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
        System.Console.WriteLine("Pick SP(Create student), E(Create Employee), C(Create Consultant), SP(show Students), EP(Show employees), CP(Show consultant)");
    }

}
