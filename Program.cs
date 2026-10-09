namespace WestCoast_Education;
using WestCoast_Education.InterFace;
using WestCoast_Education.Models;
using WestCoast_Education.Service;
class Program
{
    static void Main()
    {
        var school = new School();


        
        switch (userInput)
        {
            case"S":StudentServices.CreateNewStudent(school);
            break;

        default:break;
        }
    
      

        

        foreach (var item in school.Students)
        {
            System.Console.WriteLine(item.ToString());
        }



    }

}
