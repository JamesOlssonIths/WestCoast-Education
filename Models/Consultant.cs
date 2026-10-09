using WestCoast_Education.InterFace;

namespace WestCoast_Education.Models;

public class Consultant : Student
{
    
    public required string KnowledgeArea { get; set; }
    public required string Courses { get; set; }

    public override string ToString()
    {
        return base.ToString() + $"Knowledge area: {KnowledgeArea} \n Active courses: {Courses}";
    }


    
}
