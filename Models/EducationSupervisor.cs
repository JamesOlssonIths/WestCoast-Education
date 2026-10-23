namespace WestCoast_Education.Models;

public class EducationSupervisor : Person
{
    public DateTime StartOfEmplyoment { get; set; }
    public override string ToString()
    {
        return base.ToString() + $"Start of employment: {StartOfEmplyoment}";
    }

    public override void AskForDetails()
    {
        base.AskForDetails();
        StartOfEmplyoment = InputServices.AskForDate("employment date (yyyy-MM-dd)");
    }
}
