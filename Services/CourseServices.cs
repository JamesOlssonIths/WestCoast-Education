using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class CourseServices
{
    static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/Course.json");
    static readonly JsonStorage<Course> jsonStorage = new();

    private static Teacher? SelectTeacher()
    {
        var teachers = TeacherServices.GetAll();

        if (teachers.Count == 0)
        {
            Console.WriteLine("There are no registered teachers.");
            return null;
        }

        Console.WriteLine("Select a teacher:");

        for (var i = 0; i < teachers.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {teachers[i].FirstName} {teachers[i].LastName}");
        }

        while (true)
        {
            var selection = InputServices.AskForInt("teacher number");

            if (selection >= 1 && selection <= teachers.Count)
            {
                return teachers[selection - 1];
            }

            Console.WriteLine("Please select a teacher from the list.");
        }
    }

    public static void CreateNewCourse()
    {
       
        var course = new Course
        {
            CourseNumber = InputServices.AskForInt("course number"),
            Title = InputServices.CheckInput("course title"),
            TotalWeeks = InputServices.CheckInput("total weeks"),
            Remote = InputServices.AskForBool("Is the course remote? (y/n)"),
            StartDate = InputServices.AskForDate("start date (yyyy-MM-dd)"),
            EndDate = InputServices.AskForDate("end date (yyyy-MM-dd)"),
            Teacher = SelectTeacher()
        };


        jsonStorage.Add(Path, course);

    }   

    public static List<Course> GetCourses()
    {
        
        return jsonStorage.Read(Path);

    }




}
