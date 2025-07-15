public class Reception : Event
{
    private string _email;

    public Reception(string title, string description, string date, string time, string email) : base(title, description, date, time)
    {
        _email = email;
    }

    public override string DisplayStandard()
    {
        return "";
    }

    public override string DisplayFull()
    {
        return "";
    }

    public override string DisplayShort()
    {
        return "";
    }
}