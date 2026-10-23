using WestCoast_Education.Interfaces;
using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class PersonServices<T> where T : Person, new()
{
    static readonly string Path = string.Concat(Environment.CurrentDirectory, "/Data/", typeof(T).Name, ".json");
    static readonly JsonStorage<T> storage = new JsonStorage<T>();

  public static void CreateNew()
{
    var person = InputServices.UserInputForCreation<T>();   
    person.AskForDetails();                                  
    storage.Add(Path, person);                               
}

    public static List<T> GetAll()
    {
        return storage.Read(Path);
    }

    public static void PrintAll()
    {
        foreach (var person in GetAll())
        {
            Console.WriteLine(person);
            
        }

    }

}
