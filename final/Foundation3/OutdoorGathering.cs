public class OutdoorGathering : Event
{
    // Outdoor gathering class variables
    private string _weather;

    // Outdoor gathering constructor method
    public OutdoorGathering(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime,
    Address eventAddress, string eventWeatherReport)
    : base(eventType, eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _weather = eventWeatherReport;
    }

    // Method for returning the full details of the outdoor gathering event
    public override string GetFullDetails()
    {
        string fullDetails = GetStandardDetails() + $"Weather Forecast: {_weather}\n";
        return fullDetails;
    }
}