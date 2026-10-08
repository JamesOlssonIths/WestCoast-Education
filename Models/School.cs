namespace WestCoast_Education.Models;

public class School
{

    public List<Student> Students { get; set; } =[];
    public List<Course> Courses { get; set; } =[];
    public List<Employee> Employees {get; set;} =[];
    public List<Consultant> Consultants {get; set;} =[];

    public void AddStudent(Student student)=>Students.Add(student);
    
    public void AddCourse(Course course)=>Courses.Add(course);

    public void AddEmployee(Employee employee)=>Employees.Add(employee);
    
    public void AddConsultant(Consultant consultant)=>Consultants.Add(consultant);

    
  
    

}
