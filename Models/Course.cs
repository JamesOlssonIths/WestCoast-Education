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
     public Teacher? Teacher { get; set; }

    public void AssignTeacher(Teacher teacher)
    {
        if (teacher is null)
        {
            throw new ArgumentNullException(nameof(teacher));
        }

        Teacher = teacher;
    }
    
    public override string ToString()
    {
        return $"------- \nCourse number : {CourseNumber} \nTitle : {Title} \nTotal weeks : {TotalWeeks} \nRemote : {Remote} \nStart date : {StartDate} \nEnd date : {EndDate} \n  Teacher : {Teacher.FirstName}";
    }
}


