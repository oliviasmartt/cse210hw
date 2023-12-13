public class Activity
{
    protected string _OSdate;
    protected int _OStime;
    protected string _OStypeOfActivity;

    public Activity(string OSdate, string OStypeOfActivity, int OStime)
    {
        _OSdate = OSdate;
        _OStypeOfActivity = OStypeOfActivity;
        _OStime = OStime;
    }
    public string OSGetSummary()
    {
        return $"{_OSdate} {_OStypeOfActivity} ({_OStime}min)> Distance {OSGetDistance()} km || Speed: {Math.Round(OSGetSpeed(), 2)} kph || Pace: {Math.Round(OSGetPace(), 2)} min per km";
    }
    protected virtual double OSGetDistance()
    {
        return 0;
    }
    protected virtual double OSGetSpeed()
    {
        return 0;
    }
    protected virtual double OSGetPace()
    {
        return 0;
    }
    protected int OSGetTimeInMinutes()
    {
        return _OStime;
    }
}