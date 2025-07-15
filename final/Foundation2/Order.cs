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
        if (_customer.InUsa())
        {
            ordertotal += 5;
        }
        else
        {
            ordertotal += 35;
        }
        return ordertotal;
    }

    public string PackingLabel()
    {
        string label = $"Packing label:\n";
        foreach (var p in _productList)
        {
            label += $"{p.GetId()} - {p.GetName()}\n";
        }
        label += $"\nOrder Total: ${OrderTotal()}";
        return label;
    }

    public string ShippingLabel()
    {
        return $"{_customer.CustomerString()}";
    }
}