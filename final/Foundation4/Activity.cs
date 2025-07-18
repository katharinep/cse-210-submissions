public abstract class Activity
{
    protected DateTime _date;
    protected double _duration;

    public Activity(DateTime date, double duration)
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
}