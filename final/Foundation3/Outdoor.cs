public class Outdoor : Event
{
    private string _weather;

    public Outdoor(string title, string description, string date, string time, string address, string weather) : base(title, description, date, time, address)
    {
        _weather = weather;
    }

    public override string DisplayStandard()
    {
        return $"{_title}\n{_description}\n{_address}/n{_date} {_time}";
    }

    public override string DisplayFull()
    {
         return $"{_title}\n{_description}\n{_address}/n{_date} {_time}\n{_weather}";
    }

    public override string DisplayShort()
    {
        return $"Outdoor Event: {_title} on {_date}";
    }
}