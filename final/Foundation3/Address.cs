public class Address
{
    private string _OSstreet;
    private string _OScity;
    private string _OSstate;
    private string _OSzipCode;
    private string _OScountry;

    public Address(string OSstreet, string OScity, string OSstate, string OSzipCode, string OScountry)
    {
        _OSstreet = OSstreet;
        _OScity = OScity;
        _OSstate = OSstate;
        _OSzipCode = OSzipCode;
        _OScountry = OScountry;
    }
    public override string ToString()
    {
        return $"Address:\n   {_OSstreet}\n   {_OScity}\n   {_OSstate}\n   {_OSzipCode}\n   {_OScountry}";
    }
}