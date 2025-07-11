public class Customer
{
    private string _customerName;
    private Address _customerAddress = new Address();

    public Customer(string customername, Address customeraddress)
    {
        _customerName = customername;
        _customerAddress = new Address();
    }

    public string CustomerString()
    {
        return $"{_customerName}\n{_customerAddress}";
    }

    public bool InUsa()
    {
        string country = _customerAddress.GetCountry();
        if (country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}