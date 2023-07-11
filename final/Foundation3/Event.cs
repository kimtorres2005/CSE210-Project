public class Event
{
    // Event class variables
    private string _type;
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // Event constructor method
    public Event(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime, Address eventAddress)
    {
        _type = eventType;
        _title = eventTitle;
        _description = eventDescription;
        _date = eventDate;
        _time = eventTime;
        _address = eventAddress;
    }

    // Method that returns a short description of the event
    public string GetShortDescription()
    {
        string shortDetails = $"Event Type: {_type}\nEvent Title: {_title}\nEvent Date: {_date}\n";
        return shortDetails;
    }

    // Method that returns a standard description of the event
    public string GetStandardDetails()
    {
        string standardDetails = $"Event Title: {_title}\nEvent Description: {_description}\nEvent Date: {_date}\nEvent Time: {_time}\nEvent Address: {_address.GetFormattedAddress()}\n";
        return standardDetails;
    }

    // Virtual method that will be overridden by subclasses and will return the complete and full details of a specific event
    public virtual string GetFullDetails()
    {
        return "";
    }
}