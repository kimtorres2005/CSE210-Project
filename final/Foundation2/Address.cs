
public class Address
{
    // Address variables
    private string street;
    private string city;
    private string state_province;
    private string country;
    private bool isUSA;

    // Address constructor method
    public Address(string street_address, string city_address, string state_province_address, string country_address)
    {
        street = street_address;
        city = city_address;
        state_province = state_province_address;
        country = country_address;
        if (country.Equals("USA") || country.Equals("United States")) isUSA = true;
    }

    // Method that returns a boolean which is true if the country is USA
    public bool getIsUSA()
    {
        return isUSA;
    }

    // This method returns the address in a formatted string to be used for a label
    public string formattedAddress()
    {
        string faddress = string.Format("{0}\n{1}, {2}\n{3}", street, city, state_province, country);
        return faddress;
    }

    // GETTER AND SETTER METHODS FOR PRIVATE VARIABLES
    public string getStreet()
    {
        return street;
    }
    public void setStreet(string new_street)
    {
        street = new_street;
    }
    public string getCity()
    {
        return city;
    }
    public void setCity(string new_city)
    {
        city = new_city;
    }
    public string getStateProvince()
    {
        return state_province;
    }
    public void setStateProvince(string new_state_province)
    {
        state_province = new_state_province;
    }
    public string getCountry()
    {
        return country;
    }
    public void setCountry(string new_country)
    {
        country = new_country;
    }
}