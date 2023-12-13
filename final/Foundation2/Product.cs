public class Product
{
    private string _OSname;
    private string _OSproductID;
    private float _OSindividualPrice;
    private float _OStotalPrice;
    private int _OSquantity;

    public Product(string OSname, string OSproductID, float OSindividualPrice, int OSquantity)
    {
        _OSname = OSname;
        _OSproductID = OSproductID;
        _OSindividualPrice = OSindividualPrice;
        _OSquantity = OSquantity;
        OSCalculateTotalPrice();
    }
    private void OSCalculateTotalPrice()
    {
        _OStotalPrice = _OSindividualPrice * _OSquantity;
    }

    //GETTERS
    public string OSGetProductName()
    {
        return _OSname;
    }
    public string OSGetProductID()
    {
        return _OSproductID;
    }
    public float OSGetIndividualPrice()
    {
        return _OSindividualPrice;
    }
    public float OSGetTotalPrice()
    {
        return _OStotalPrice;
    }
    public int OSGetQuantity()
    {
        return _OSquantity;
    }

}