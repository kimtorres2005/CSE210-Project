public class Address
{
    // Address class variables
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    // Address constructor method
    public Address(string streetAddress, string cityAddress, string stateProvinceAddress, string countryAddress)
    {
        _street = streetAddress;
        _city = cityAddress;
        _stateProvince = stateProvinceAddress;
        _country = countryAddress;
    }

    // This method returns the address in a formatted string
    public string GetFormattedAddress()
    {
        string formattedAddress = $"\n{_street}\n{_city}, {_stateProvince}\n{_country}";
        return formattedAddress;
    }
}