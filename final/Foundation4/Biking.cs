public class Biking : Activity
{
    private float _pace;

    public Biking(string date, string duration, float pace) : base(date, duration)
    {
        _pace = pace;
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