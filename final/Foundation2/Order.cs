public class Order
{
    private List<Product> _productList = new List<Product>();
    private List<Customer> _customerList = new List<Customer>();

    public Order()
    {

    }

    public float OrderTotal()
    {
        return 0;
    }

    public float ShippingCost()
    {
        return 0;
    }

    public string PackingLabel()
    {
        return "";
    }

    public string ShippingLabel()
    {
        return "";
    }
}