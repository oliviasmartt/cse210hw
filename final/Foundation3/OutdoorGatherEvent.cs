public class OutdoorGatheringEvent : Event
{
    private string _OSweatherForecast;
    public OutdoorGatheringEvent(string OStitle, string OSdescription, string OSdate, string OStime, Address OSaddress, string OSweatherForecast) : base(OStitle, OSdescription, OSdate, OStime, OSaddress, "Outdoor Gathering")
    {
        _OSweatherForecast = OSweatherForecast;
    }
    public override string OSFullDetails()
    {
        return OSStandardDetails() + $"\nWeather Forecast: {_OSweatherForecast}\n";
    }
}