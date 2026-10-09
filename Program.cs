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
            var school = new School();
            
            IntroMessages();
            switch (Console.ReadLine())
            {
                case"S":StudentServices.CreateNewStudent(school);
                break;
                case"P":var students = StudentServices.GetStudents();
                foreach (var student in students)
                {
                    Console.WriteLine(
                    $"{student.FirstName} {student.LastName} | " +
                    $"{student.PhoneNumber} | {student.Address} | " +
                    $"{student.City}, {student.CityNumber}");
                }
                break;
                case"E":EmployeeServices.CreateNewEmployee(school);
                break;
                case"C":ConsultentServices.CreateNewConsultant(school);
                break;

                default:break;
            }
        }

    }

    static void IntroMessages()
    {
        System.Console.WriteLine("Pick S(Create student), E(Create Employee), C(Create Consultant), P(show Students)");
    }

}
