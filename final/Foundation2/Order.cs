public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public float OrderTotal()
    {
        float ordertotal = 0;
        foreach (var product in _productList)
        {
            float item = product.ProductTotal();
            ordertotal += item;
        }
        bool country = _customer.InUsa();
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