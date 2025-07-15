public abstract class Activity
{
    private string _date;
    private string _duration;
    private List<string> _activityList = new List<string>();

    public Activity(string date, string duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual string DisplaySummary()
    {
        return "";
    }

    public virtual string GetDistance()
    {
        return "";
    }

    public virtual string GetSpeed()
    {
        return "";
    }

    public virtual string GetPace()
    {
        return "";
    }

    public virtual void AddActivity()
    {
        
    }
}