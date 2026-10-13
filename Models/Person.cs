using WestCoast_Education.InterFace;

namespace WestCoast_Education;

public class Person : IPerson // Required
{
    public string FirstName { get; set; } ="";
    public string LastName { get; set; } ="";
    public string PhoneNumber { get; set; } ="";
    public string SocialSecurityNumber { get; set ; } ="";
    public string Address { get; set; } ="";
    public string CityNumber { get ; set; } ="";
    public string City { get ; set; } ="";
   
    
    public override string ToString()
    {
        return $"------- \nName : {FirstName} {LastName} \nPhonenumber : {PhoneNumber} \nAddress : {Address} \nCity : {City} \n";
    }
}
