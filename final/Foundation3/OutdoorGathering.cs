public class OutdoorGathering : Event
{
    // Outdoor gathering class variables
    private string weather;

    // Outdoor gathering constructor method
    public OutdoorGathering(string event_type, string event_title, string event_description, string event_date, string event_time,
    Address event_address, string event_weatherReport)
    : base(event_type, event_title, event_description, event_date, event_time, event_address)
    {
        weather = event_weatherReport;
    }

    // Method for returning the full details of the outdoor gathering event
    public override string getFullDetails()
    {
        string full_details;
        full_details = getStandardDetails() + String.Format("Weather Forecast: {0}\n", weather);
        return full_details;
    }
}