using WestCoast_Education.Models;

namespace WestCoast_Education.Service;

public class PersonServices<T> where T : Person, new()
{


    static readonly string Path = string.Concat(Environment.CurrentDirectory,"/Data/", typeof(T).Name,".Json");
    static readonly JsonStorage<T> jsonStorage = new();

    public static void CreateNew()
    {
        var person = InputServices.UserInputForCreation<T>();
        //person.AskForDetails();  
        jsonStorage.Add(Path, person);
    }

    // public static List<T> GetJson<T>()
    // {
    //     //return jsonStorage.Read(Path);  
    // }

}
