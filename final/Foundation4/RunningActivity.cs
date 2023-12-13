public class RunningActivity : Activity
{
    private double _OSdistance;
    public RunningActivity(string OSdate, double OSdistance, int OStime) : base(OSdate, "Running Activity", OStime)
    {
        _OSdistance = OSdistance;
    }

    protected override double OSGetDistance()
    {
        return _OSdistance;
    }
    protected override double OSGetSpeed()
    {
        return (_OSdistance / OSGetTimeInMinutes()) * 60.0;
    }
    protected override double OSGetPace()
    {
        return OSGetTimeInMinutes() / OSGetDistance();
    }
}