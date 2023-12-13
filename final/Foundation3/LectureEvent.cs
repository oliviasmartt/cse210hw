public class LectureEvent : Event
{
    private string _OSspeaker;
    private string _OSlimitedCapacity;

    public LectureEvent(string OStitle, string OSdescription, string OSdate, string OStime, Address OSaddress, string OSspeaker, string OSlimitedCapacity) : base(OStitle, OSdescription, OSdate, OStime, OSaddress, "Lecture")
    {
        _OSspeaker = OSspeaker;
        _OSlimitedCapacity = OSlimitedCapacity;
    }
    public override string OSFullDetails()
    {
        return OSStandardDetails() + $"\nSpeaker: {_OSspeaker}\nCapacity: {_OSlimitedCapacity}\n";
    }
}