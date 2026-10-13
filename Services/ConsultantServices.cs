using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class ConsultentServices
{

    static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/Consultant.json");
    static readonly Storage<Consultant> storage = new();

    public static void CreateNewConsultant()
    {
        var Consultant = InputSerivcesPerson.UserInputForCreation<Consultant>();

        Consultant.KnowledgeArea = InputSerivcesPerson.CheckInput("Knowledge area");
        Consultant.Courses = InputSerivcesPerson.CheckInput("Courses");

        storage.Add(Path, Consultant);

    }
    public static List<Consultant> GetConsultant()
    {
        return storage.Read(Path);
    }

}
