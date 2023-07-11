// Running class, derived from Activity
public class Running : Activity
{
    // Running class variables
    private double _distance;

    // Running activity constructor method
    public Running(int duration, string date, double distance)
        : base("Running", duration, date)
    {
        _distance = distance;
    }

    // Method for getting the distance
    public override double GetDistance()
    {
        return _distance;
    }

    // Method for getting the speed
    public override double GetSpeed()
    {
        return (_distance / GetDuration()) * 60.00;
    }

    // Method for getting the pace
    public override double GetPace()
    {
        return 60.00 / GetSpeed();
    }

    // Method for returning the activity summary
    public override string GetSummary()
    {
        return string.Format("{0} - {1} ({2} min): Distance {3:N2} miles, Speed: {4:N2} mph, Pace: {5:N2} min per mile",
            GetDate(), GetType(), GetDuration(), GetDistance(), GetSpeed(), GetPace());
    }
}