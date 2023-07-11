public class Reception : Event
{
    // Reception class variables
    private string _emailRSVP;

    // Reception constructor method
    public Reception(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime,
    Address eventAddress, string eventEmailRSVP)
    : base(eventType, eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _emailRSVP = eventEmailRSVP;
    }

    // Method for returning the full details of the reception event
    public override string GetFullDetails()
    {
        string fullDetails = GetStandardDetails() + $"Please RSVP for this event at {_emailRSVP}\n";
        return fullDetails;
    }
}