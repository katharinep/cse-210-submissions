public class Running : Activity
{
    private float _distance;

    public Running(string date, string duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override string DisplaySummary()
    {
        return "";
    }

    public override string GetDistance()
    {
        return "";
    }

    public override string GetSpeed()
    {
        return "";
    }

    public override string GetPace()
    {
        return "";
    }

    public override void AddActivity()
    {
        
    }
}