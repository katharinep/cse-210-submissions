public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address()
    {
        
    }
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public string GetCountry()
    {
        return _country;
    }

    public string AddressString()
    {
        return $"{_street}\n{_city}, {_state} {_country}";
    }

    public bool IsUsa()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}