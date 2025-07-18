public abstract class Activity
{
    protected string _date;
    protected double _duration;
    protected List<string> _activityList = new List<string>();

    public Activity(string date, double duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual string DisplaySummary()
    {
        return "";
    }

    public virtual double GetDistance()
    {
        return 0;
    }

    public virtual double GetSpeed()
    {
        return 0;
    }

    public virtual double GetPace()
    {
        return 0;
    }

    public virtual void AddActivity()
    {
        
    }
}