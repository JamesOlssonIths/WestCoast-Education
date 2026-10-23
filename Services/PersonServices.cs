using WestCoast_Education.Interfaces;
using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class PersonServices<T> where T : Person, new()
{
    static readonly string Path = string.Concat(Environment.CurrentDirectory, "/Data/", typeof(T).Name, ".json");
    static readonly JsonStorage<T> storage = new JsonStorage<T>();

  public static void CreateNew()
{
    var person = InputServices.UserInputForCreation<T>();   // 1. create it and ask the basic questions
    person.AskForDetails();                                  // 2. ask the extra questions
    storage.Add(Path, person);                               // 3. save it
}

    public static List<T> GetAll(string path)
    {
        return storage.Read(Path);
    }

}
