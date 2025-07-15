public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string weather) : base(title, description, date, time)
    {
        _weather = weather;
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