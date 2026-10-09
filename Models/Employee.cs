using WestCoast_Education.InterFace;

namespace WestCoast_Education.Models;

public class Employee : Student
{
    public required string StartOfEmplyoment { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"Start of employment: {StartOfEmplyoment}";
    }
}
