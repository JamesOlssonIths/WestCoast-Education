using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class CourseServices
{
    static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/Course.json");
    static readonly JsonStorage<Course> jsonStorage = new();


    public static void CreateNewCourse()
    {
        
        var course = new Course
        {
            CourseNumber = InputServices.AskForInt("course number"),
            Title = InputServices.CheckInput("course title"),
            TotalWeeks = InputServices.CheckInput("total weeks"),
            Remote = InputServices.AskForBool("Is the course remote? (y/n)"),
            StartDate = InputServices.AskForDate("start date (yyyy-MM-dd)"),
            EndDate = InputServices.AskForDate("end date (yyyy-MM-dd)")
        };


        jsonStorage.Add(Path, course);

    }   

    public static List<Course> GetCourses()
    {
        
        return jsonStorage.Read(Path);

    }




}
