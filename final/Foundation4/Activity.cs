// Activity base class
public class Activity
{
    // Activity class variables
    private string type;
    private int duration;
    private string date;

    // Activity constructor method
    public Activity(string activity_type, int activity_duration, string activity_date)
    {
        type = activity_type;
        duration = activity_duration;
        date = activity_date;
    }

    // Virtual method for getting the distance
    public virtual double getDistance()
    {
        return 0;
    }

    // Virtual method for getting the speed
    public virtual double getSpeed()
    {
        return 0;
    }

    // Virtual method for getting the pace
    public virtual double getPace()
    {
        return 0;
    }

    // Virtual method for returning the activity summary
    public virtual string getSummary()
    {
        return "";
    }

    // Getter methods for private variables
    public int getDuration()
    {
        return duration;
    }
    public string getDate()
    {
        return date;
    }
    public string getType()
    {
        return type;
    }
}