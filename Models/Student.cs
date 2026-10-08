using WestCoast_Education.InterFace;


namespace WestCoast_Education.Models;

public class Student : IPerson
{
    public required string FirstName { get; set; } ="";
    public required string LastName { get; set; } ="";
    public required string PhoneNumber { get; set; } ="";
    public required string SocialSecurityNumber { get; set ; } ="";
    public required string Address { get; set; } ="";
    public required string CityNumber { get ; set; } ="";
    public required string City { get ; set; } ="";



    public override string ToString()
    {
        return $"First name : {FirstName} | Last name : {LastName} \nPhonenumber : {PhoneNumber} \nAddress : {Address} \nCity : {City} \n";
    }


    



}
