public class CyclingActivity : Activity
{
    private double _OSspeed;

    public CyclingActivity(string OSdate, double OSspeed, int OStime) : base(OSdate, "Cycling Activity", OStime)
    {
        _OSspeed = OSspeed;
    }
    protected override double OSGetDistance()
    {
        return (_OSspeed / 60.0) * OSGetTimeInMinutes();
    }
    protected override double OSGetSpeed()
    {
        return _OSspeed;
    }
    protected override double OSGetPace()
    {
        return OSGetTimeInMinutes() / OSGetDistance();
    }
}