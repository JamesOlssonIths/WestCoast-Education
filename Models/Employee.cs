using WestCoast_Education.InterFace;

namespace WestCoast_Education.Models;

public class Employee : Student
{
    public string StartOfEmplyoment { get; set; } ="Januari";
    public override string ToString()
    {
        return base.ToString() + $"Start of employment: {StartOfEmplyoment}";
    }
}
