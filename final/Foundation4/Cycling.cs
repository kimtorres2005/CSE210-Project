// Cycling class, derived from Activity
public class Cycling : Activity
{
    // Cycling class variables
    private double _speed;

    // Cycling constructor method
    public Cycling(int duration, string date, double speed)
        : base("Cycling", duration, date)
    {
        _speed = speed;
    }

    // Method for getting the distance
    public override double GetDistance()
    {
        return GetSpeed() * (Convert.ToDouble(GetDuration()) / 60.00);
    }

    // Method for getting the speed
    public override double GetSpeed()
    {
        return _speed;
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