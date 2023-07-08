public class Reception : Event
{
    // Reception class variables
    private string emailRSVP;

    // Reception constructor method
    public Reception(string event_type, string event_title, string event_description, string event_date, string event_time,
    Address event_address, string event_emailRSVP)
    : base(event_type, event_title, event_description, event_date, event_time, event_address)
    {
        emailRSVP = event_emailRSVP;
    }

    // Method for returning the full details of the reception event
    public override string getFullDetails()
    {
        string full_details;
        full_details = getStandardDetails() + String.Format("Please RSVP for this event at {0}\n", emailRSVP);
        return full_details;
    }
}