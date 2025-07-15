public class Product
{
    private string _id;
    private string _name;
    private float _price;
    private int _quantity;

    public Product(string id, string name, float price, int quantity)
    {
        _id = id;
        _name = name;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }

    public string GetQuantity()
    {
        return _quantity.ToString();
    }

    public float ProductTotal()
    {
        return _price * _quantity;
    }
}