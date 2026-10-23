using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class TeacherServices
{

    static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/Consultant.json");
    static readonly JsonStorage<Teacher> jsonStorage = new();

    public static void CreateNewConsultant()
    {
        var Consultant = InputServices.UserInputForCreation<Teacher>();

        Consultant.KnowledgeArea = InputServices.CheckInput("Knowledge area");
        Consultant.Courses = InputServices.CheckInput("Courses");

        jsonStorage.Add(Path, Consultant);

    }
    public static List<Teacher> GetConsultant()
    {
        return jsonStorage.Read(Path);
    }

}
