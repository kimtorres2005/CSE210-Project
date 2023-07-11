
public class Customer
{
    // Customer variables
    private string name;
    private Address address;

// Customer constructor method
public Customer(string customerName, Address customerAddress)
{
    _name = customerName;
    _address = customerAddress;
}

// Method to return a boolean (true or false) if the address is in the United States
public bool IsAddressInUSA()
{
    return _address.GetIsUSA();
}

// Getter and setter methods for private variables
public string GetName()
{
    return _name;
}

public void SetName(string newName)
{
    _name = newName;
}

public Address GetAddress()
{
    return _address;
}

public void SetAddress(Address newAddress)
{
    _address = newAddress;
}
