public class Event
{
    // Event class variables
    private string type;
    private string title;
    private string description;
    private string date;
    private string time;
    private Address address;

    // Event constructor method
    public Event(string event_type, string event_title, string event_description, string event_date, string event_time, Address event_address)
    {
        type = event_type;
        title = event_title;
        description = event_description;
        date = event_date;
        time = event_time;
        address = event_address;
    }

    // Method that returns a short description of the event
    public string getShortDescription()
    {
        string short_details;
        short_details = String.Format("Event Type: {0}\nEvent Title: {1}\nEvent Date: {2}\n", type, title, date);
        return short_details;
    }

    // Method that returns a standard description of the event
    public string getStandardDetails()
    {
        string standard_details;
        standard_details = String.Format("Event Title: {0}\nEvent Description: {1}\nEvent Date: {2}\nEvent Time: {3}\nEvent Address: {4}\n", title, description, date, time, address.getFormattedAddress());
        return standard_details;
    }

    // Virtual method that will be overridden by subclasses and will return the complete and full details of a specific event
    public virtual string getFullDetails()
    {
        return "";
    }
}