public class Address
{
    private string _OSstreetAddress;
    private string _OScity;
    private string _OSstateOrProvince;
    private string _OScountry;

    public Address(string OSstreet, string OScity, string OSstateOrProvince, string OScountry)
    {
        _OSstreetAddress = OSstreet;
        _OScity = OScity;
        _OSstateOrProvince = OSstateOrProvince;
        _OScountry = OScountry;
    }
    public bool OSGetLivesInUSA()
    {
        if (_OScountry.ToUpper().Equals("USA"))
        {
            return true;
        }
        return false;
    }
    public string OSGetFormattedAddress()
    {
        string OSformattedAddress = $"   {_OSstreetAddress}\n   {_OScity}\n   {_OSstateOrProvince}\n   {_OScountry}";
        return OSformattedAddress;
    }
}