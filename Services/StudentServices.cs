using System.Dynamic;
using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class StudentServices
{
     static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/Student.json");
    static readonly JsonStorage<Student> jsonStorage = new();

    public static void CreateNewStudent()
    {
        var student = InputServices.UserInputForCreation<Student>();
        jsonStorage.Add(Path, student);
    }

    public static List<Student> GetStudents()
    {
        return jsonStorage.Read(Path);
    }
}
