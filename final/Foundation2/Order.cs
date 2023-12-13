public class Order
{
    private List<Product> _OSproducts;
    private Customer _OScustomer;
    private float _OStotalCost;
    private float _OSshippingCost;

    public Order(Customer OScustomer, List<Product> OSproducts)
    {
        _OScustomer = OScustomer;

        if (OScustomer.OSGetIsFromUSA())
        {
            _OSshippingCost = 4;
        }
        else
        {
            _OSshippingCost = 25;
        }
        _OSproducts = OSproducts;
        CalculateTotalCost();

    }
    private void CalculateTotalCost()
    {
        _OStotalCost = _OSshippingCost;
        foreach (Product OSproduct in _OSproducts)
        {
            _OStotalCost += OSproduct.OSGetTotalPrice();
        }
    }
    public float GetTotalCost()
    {
        return _OStotalCost;
    }
    public string GetShippingLabel()
    {
        return $"Customer Name: {_OScustomer.OSGetName()}\nCustomer Address:\n{_OScustomer.OSGetAddress().OSGetFormattedAddress()}\n";
    }
    public string GetPackingLabel()
    {
        string OSpackingLabel = "";
        int OScont = 1;
        foreach (Product OSproduct in _OSproducts)
        {
            OSpackingLabel += $"Product N{OScont}:\nProduct Name: {OSproduct.OSGetProductName()}\nProduct ID: {OSproduct.OSGetProductID()}\nProduct Price: ${OSproduct.OSGetIndividualPrice()}\nProduct Quantity: {OSproduct.OSGetQuantity()}\n\n";
            OScont += 1;
        }
        return OSpackingLabel;
    }

}