public class Order
{
    private List<Product> _productList = new List<Product>();
    private List<Customer> _customerList = new List<Customer>();

    public Order()
    {

    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public void AddCustomer(Customer customer)
    {
        _customerList.Add(customer);
    }

    public float OrderTotal()
    {
        float ordertotal = 0;
        foreach (var product in _productList)
        {
            float item = product.ProductTotal();
            ordertotal += item;
        }
        return ordertotal;
    }

    public float ShippingCost()
    {
        
    }

    public string PackingLabel()
    {
        return $"";
    }

    public string ShippingLabel()
    {
        return $"{}";
    }
}