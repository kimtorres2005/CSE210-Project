public class Lecture : Event
{
    // Lecture class variables
    private string _speaker;
    private int _capacity;

    // Lecture constructor method
    public Lecture(string eventType, string eventTitle, string eventDescription, string eventDate, string eventTime,
    Address eventAddress, string eventSpeaker, int eventCapacity)
    : base(eventType, eventTitle, eventDescription, eventDate, eventTime, eventAddress)
    {
        _speaker = eventSpeaker;
        _capacity = eventCapacity;
    }

    // Method for returning the full details of the lecture event
    public override string GetFullDetails()
    {
        string fullDetails = GetStandardDetails() + $"Event Speaker: {_speaker}\nEvent Capacity: {_capacity}\n";
        return fullDetails;
    }
}