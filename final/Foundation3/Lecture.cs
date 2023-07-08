public class Lecture : Event
{
    // Lecture class variables
    private string speaker;
    private int capacity;

    // Lecture constructor method
    public Lecture(string event_type, string event_title, string event_description, string event_date, string event_time,
    Address event_address, string event_speaker, int event_capacity)
    : base(event_type, event_title, event_description, event_date, event_time, event_address)
    {
        speaker = event_speaker;
        capacity = event_capacity;
    }

    // Method for returning the full details of the lecture event
    public override string getFullDetails()
    {
        string full_details;
        full_details = getStandardDetails() + String.Format("Event Speaker: {0}\nEvent Capacity: {1}\n", speaker, capacity);
        return full_details;
    }
}