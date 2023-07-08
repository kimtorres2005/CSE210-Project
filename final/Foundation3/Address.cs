public class Address
{
    // Address class variables
    private string street;
    private string city;
    private string state_province;
    private string country;

    // Address constructor method
    public Address(string street_address, string city_address, string state_province_address, string country_address)
    {
        street = street_address;
        city = city_address;
        state_province = state_province_address;
        country = country_address;
    }

    // This method returns the address in a formatted string
    public string getFormattedAddress()
    {
        string faddress = string.Format("\n{0}\n{1}, {2}\n{3}", street, city, state_province, country);
        return faddress;
    }
}