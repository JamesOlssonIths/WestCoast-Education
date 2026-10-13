using WestCoast_Education.Models;

namespace WestCoast_Education.Service;
using WestCoast_Education.Models;

public class EmployeeServices
{
    static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/Employee.json");
    static readonly Storage<Employee> storage = new();

    public static void CreateNewEmployee()
    {
        var employee = InputSerivces.UserInputForCreation<Employee>();

        employee.StartOfEmplyoment = InputSerivces.CheckInput("Start of Employment");

        storage.Add(Path, employee);

    }
     public static List<Employee> GetEmployee()
    {
        return storage.Read(Path);
    }
}
