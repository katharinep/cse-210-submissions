public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string address, string email) : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string DisplayStandard()
    {
        return $"{_title}\n{_description}\n{_address}/n{_date} {_time}";
    }

    public override string DisplayFull()
    {
        return "";
    }

    public override string DisplayShort()
    {
        return $"Reception: {_title} on {_date}";
    }
}