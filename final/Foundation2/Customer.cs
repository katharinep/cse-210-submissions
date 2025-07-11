public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customername, Address customeraddress)
    {
        _customerName = customername;
        _customerAddress = customeraddress;
    }

    public string CustomerString()
    {
        return $"{_customerName}\n{_customerAddress}";
    }
}