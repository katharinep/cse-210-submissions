public class Customer
{
    private string _customerName;
    private Address _customerAddress = new Address();

    public Customer(string customername, Address customeraddress)
    {
        _customerName = customername;
        _customerAddress = customeraddress;
    }

    public string CustomerString()
    {
        return $"{_customerName}\n{_customerAddress.AddressString()}";
    }

    public bool InUsa()
    {
        return _customerAddress.IsUsa();
        
    }
}