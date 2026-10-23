using WestCoast_Education.Models;

namespace WestCoast_Education;

public class Course
{
    public int CourseNumber { get; set; }
    public string? Title { get; set; }
    public string? TotalWeeks { get; set; }
    public bool Remote { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime StartDate { get; set; }

    public List<Student> Students { get; set; } =[];
    public Consultant? Consultant { get; set; }
    
    public override string ToString()
    {
        return $"------- \nCourse number : {CourseNumber} \nTitle : {Title} \nTotal weeks : {TotalWeeks} \nRemote : {Remote} \nStart date : {StartDate} \nEnd date : {EndDate} \n";
    }
}


