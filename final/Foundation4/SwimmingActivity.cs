public class Swimming : Activity
{
    private int _OSnumberOfLaps;

    public Swimming(string OSdate, int OSnumberOfLaps, int OStime) : base(OSdate, "Swimming Activity", OStime)
    {
        _OSnumberOfLaps = OSnumberOfLaps;
    }

    protected override double OSGetDistance()
    {
        return (_OSnumberOfLaps * 50.0) / 1000;
    }
    protected override double OSGetSpeed()
    {
        return (OSGetDistance() / OSGetTimeInMinutes()) * 60.0;
    }
    protected override double OSGetPace()
    {
        return OSGetTimeInMinutes() / OSGetDistance();
    }
}