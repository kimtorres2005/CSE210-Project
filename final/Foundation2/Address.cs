
public class Address
{
    // Address variables
    private string street;
    private string city;
    private string state_province;
    private string country;
    private bool isUSA;

// Address constructor method
public Address(string streetAddress, string cityAddress, string stateProvinceAddress, string countryAddress)
{
    _street = streetAddress;
    _city = cityAddress;
    _stateProvince = stateProvinceAddress;
    _country = countryAddress;
    if (_country.Equals("USA") || _country.Equals("United States")) _isUSA = true;
}

// Method that returns a boolean which is true if the country is USA
public bool GetIsUSA()
{
    return _isUSA;
}

// This method returns the address in a formatted string to be used for a label
public string FormattedAddress()
{
    string formattedAddress = string.Format("{0}\n{1}, {2}\n{3}", _street, _city, _stateProvince, _country);
    return formattedAddress;
}

// Getter and setter methods for private variables
public string GetStreet()
{
    return _street;
}

public void SetStreet(string newStreet)
{
    _street = newStreet;
}

public string GetCity()
{
    return _city;
}

public void SetCity(string newCity)
{
    _city = newCity;
}

public string GetStateProvince()
{
    return _stateProvince;
}

public void SetStateProvince(string newStateProvince)
{
    _stateProvince = newStateProvince;
}

public string GetCountry()
{
    return _country;
}

public void SetCountry(string newCountry)
{
    _country = newCountry;
}
