public class Event
{
    private string _OStitle;
    private string _OSdescription;
    private string _OSdate;
    private string _OStime;
    private Address _OSaddress;
    private string _OStype;


    public Event(string OStitle, string OSdescription, string OSdate, string OStime, Address OSaddress, string OStype)
    {
        _OStitle = OStitle;
        _OSdescription = OSdescription;
        _OSdate = OSdate;
        _OStime = OStime;
        _OStype = OStype;
        _OSaddress = OSaddress;
    }
    public string OSStandardDetails()
    {
        return $"Title: {_OStitle}\nDescription: {_OSdescription}\nDate: {_OSdate}\nTime: {_OStime}\n{_OSaddress.ToString()}\n";
    }
    public virtual string OSFullDetails()
    {
        return "";
    }
    public string OSShortDetails()
    {
        return $"Type: {_OStype}\nTitle: {_OStitle}\nDate: {_OSdate}\n";
    }
}