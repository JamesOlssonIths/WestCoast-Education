namespace WestCoast_Education.InterFace;

public interface IPerson
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }
    public string SocialSecurityNumber { get; set; }
    public string Address { get; set; }
    public string CityNumber { get; set; }
    public string City { get; set; }

    string ToString();
    
    

}
