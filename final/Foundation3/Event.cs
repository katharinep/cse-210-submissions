public abstract class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;

    public Event(string title, string description, string date, string time)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
    }

    public virtual string DisplayStandard()
    {
        return "";
    }

    public virtual string DisplayFull()
    {
        return "";
    }

    public virtual string DisplayShort()
    {
        return "";
    }
}