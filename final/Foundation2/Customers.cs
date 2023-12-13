public class Customer
{
    private string _OSname;
    private Address _OSaddres;

    public Customer(string OSname, Address OSaddress)
    {
        _OSname = OSname;
        _OSaddres = OSaddress;

    }
    public string OSGetName()
    {
        return _OSname;
    }
    public bool OSGetIsFromUSA()
    {
        return _OSaddres.OSGetLivesInUSA();
    }
    public Address OSGetAddress()
    {
        return _OSaddres;
    }

}