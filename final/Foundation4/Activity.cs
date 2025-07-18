public abstract class Activity
{
    protected string _date;
    protected float _duration;
    protected List<string> _activityList = new List<string>();

    public Activity(string date, float duration)
    {
        _date = date;
        _duration = duration;
    }

    public virtual string DisplaySummary()
    {
        return "";
    }

    public virtual float GetDistance()
    {
        return 0;
    }

    public virtual float GetSpeed()
    {
        return 0;
    }

    public virtual float GetPace()
    {
        return 0;
    }

    public virtual void AddActivity()
    {
        
    }
}