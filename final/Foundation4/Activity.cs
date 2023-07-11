// Activity base class
public class Activity
{
    // Activity class variables
    private string _type;
    private int _duration;
    private string _date;

    // Activity constructor method
    public Activity(string type, int duration, string date)
    {
        _type = type;
        _duration = duration;
        _date = date;
    }

    // Virtual method for getting the distance
    public virtual double GetDistance()
    {
        return 0;
    }

    // Virtual method for getting the speed
    public virtual double GetSpeed()
    {
        return 0;
    }

    // Virtual method for getting the pace
    public virtual double GetPace()
    {
        return 0;
    }

    // Virtual method for returning the activity summary
    public virtual string GetSummary()
    {
        return "";
    }

    // Getter methods for private variables
    public int GetDuration()
    {
        return _duration;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetType()
    {
        return _type;
    }
}
