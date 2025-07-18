public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, string duration, int laps) : base(date, duration)
    {
        _laps = laps;
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