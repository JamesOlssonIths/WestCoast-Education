using WestCoast_Education.Models;

namespace WestCoast_Education.Service;


public class EducationSupervisorServices
{
    static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/Employee.json");
    static readonly JsonStorage<EducationSupervisor> jsonStorage = new();

    public static void CreateNewEmployee()
    {
        var employee = InputServices.UserInputForCreation<EducationSupervisor>();

        employee.StartOfEmplyoment = InputServices.AskForDate("Start of Employment");

        jsonStorage.Add(Path, employee);

    }
    public static List<EducationSupervisor> GetEmployee()
    {
        return jsonStorage.Read(Path);
    }
}
