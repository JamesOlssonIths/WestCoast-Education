namespace WestCoast_Education.Models;

public class EducationSupervisor : Person
{
    public string StartOfEmplyoment { get; set; } ="";
    public override string ToString()
    {
        return base.ToString() + $"Start of employment: {StartOfEmplyoment}";
    }
}
