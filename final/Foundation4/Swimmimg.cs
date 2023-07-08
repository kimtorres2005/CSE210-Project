// Swimming class, derived from Activity
public class Swimming : Activity
{
    // Swimming class variables
    private int laps;

    // Swimming constructor method
    public Swimming(int activity_duration, string activity_date, int activity_laps)
    : base("Swimming", activity_duration, activity_date)
    {
        laps = activity_laps;
    }

    // Method for getting the number of laps
    public int getLaps()
    {
        return laps;
    }
    // Method for getting the distance
    public override double getDistance()
    {
        return ((Convert.ToDouble(getLaps()) * 50.00) / 1000.00) * 0.62;
    }
    // Method for getting the speed
    public override double getSpeed()
    {
        return (getDistance() / getDuration()) * 60.00;
    }
    // Method for getting the pace
    public override double getPace()
    {
        return 60.00 / getSpeed();
    }
    // Method for returning the activity summary
    public override string getSummary()
    {
        return String.Format("{0} - {1} ({2} min): Distance {3:N2} miles, Speed: {4:N2} mph, Pace: {5:N2} min per mile, Laps: {6}",
        getDate(), getType(), getDuration(), getDistance(), getSpeed(), getPace(), getLaps());
    }
}