
using WestCoast_Education.Models;

namespace WestCoast_Education;

public class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string PhoneNumber { get; set; } = "";
    public string SocialSecurityNumber { get; set; } = "";
    public Address Address { get; set; } = new();

    public override string ToString()
    {
        return $"------- \nName : {FirstName} {LastName} \nPhonenumber : {PhoneNumber} \nSocial security number : {SocialSecurityNumber} \nAddress : {Address} \n";
    }
}
