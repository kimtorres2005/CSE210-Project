// Running class, derived from Activity
public class Running : Activity
{
    // Running class variables
    private double distance;

    // Running activity constructor method
    public Running(int activity_duration, string activity_date, double activity_distance)
    : base("Running", activity_duration, activity_date)
    {
        distance = activity_distance;
    }

    // Method for getting the distance
    public override double getDistance()
    {
        return distance;
    }
    // Method for getting the speed
    public override double getSpeed()
    {
        return (distance / getDuration()) * 60.00;
    }
    // Method for getting the pace
    public override double getPace()
    {
        return 60.00 / getSpeed();
    }
    // Method for returning the activity summary
    public override string getSummary()
    {
        return String.Format("{0} - {1} ({2} min): Distance {3:N2} miles, Speed: {4:N2} mph, Pace: {5:N2} min per mile",
        getDate(), getType(), getDuration(), getDistance(), getSpeed(), getPace());
    }
}