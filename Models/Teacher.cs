namespace WestCoast_Education.Models;

public class Teacher : Person
{
    
    public string KnowledgeArea { get; set; } ="";
    public string Courses { get; set; } ="";

    public override string ToString()
    {
        return base.ToString() + $"Knowledge area: {KnowledgeArea} \nActive courses: {Courses}";
    }
    public override void AskForDetails()
    {
        KnowledgeArea = InputServices.CheckInput("knowledge area");
    }


    
}
