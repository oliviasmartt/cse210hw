public class ReceptionEvent : Event
{
    private string _OSRSVP;

    public ReceptionEvent(string OStitle, string OSdescription, string OSdate, string OStime, Address OSaddress, string OSRSVP) : base(OStitle, OSdescription, OSdate, OStime, OSaddress, "Reception")
    {
        _OSRSVP = OSRSVP;
    }
    public override string OSFullDetails()
    {
        return OSStandardDetails() + $"\nRSVP Email: {_OSRSVP}\n";
    }
}