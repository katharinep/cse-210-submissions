public class Lecture : Event
{
    private string _speaker;
    private string _capacity;

    public Lecture(string title, string description, string date, string time, string address, string speaker, string capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public override string DisplayStandard()
    {
        return $"{_title}\n{_description}\n{_address}\n{_date} {_time}";
    }

    public override string DisplayFull()
    {
         return $"{_title} by {_speaker}\n{_description}\n{_address}\n{_date} {_time}\nEvent Capacity: {_capacity}";
    }

    public override string DisplayShort()
    {
        return $"Lecture: {_title} on {_date}";
    }
}