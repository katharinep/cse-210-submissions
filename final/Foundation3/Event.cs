public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;

    public Event(string title, string description, string date, string time, string address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string DisplayStandard()
    {
        return $"{_title}\n{_description}\n{_address}\n{_date} {_time}";
    }

    public virtual string DisplayFull()
    {
        return $"{_title}\n{_description}\n{_address}\n{_date} {_time}";
    }

    public virtual string DisplayShort()
    {
        return $"{_title} {_date}";
    }
}