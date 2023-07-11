// Swimming class, derived from Activity
public class Swimming : Activity
{
    // Swimming class variables
    private int _laps;

    // Swimming constructor method
    public Swimming(int duration, string date, int laps)
        : base("Swimming", duration, date)
    {
        _laps = laps;
    }

    // Method for getting the number of laps
    public int GetLaps()
    {
        return _laps;
    }

    // Method for getting the distance
    public override double GetDistance()
    {
        return ((Convert.ToDouble(GetLaps()) * 50.00) / 1000.00) * 0.62;
    }

    // Method for getting the speed
    public override double GetSpeed()
    {
        return (GetDistance() / GetDuration()) * 60.00;
    }

    // Method for getting the pace
    public override double GetPace()
    {
        return 60.00 / GetSpeed();
    }

    // Method for returning the activity summary
    public override string GetSummary()
    {
        return string.Format("{0} - {1} ({2} min): Distance {3:N2} miles, Speed: {4:N2} mph, Pace: {5:N2} min per mile, Laps: {6}",
            GetDate(), GetType(), GetDuration(), GetDistance(), GetSpeed(), GetPace(), GetLaps());
    }
}