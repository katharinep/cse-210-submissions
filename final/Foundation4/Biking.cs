public class Biking : Activity
{
    private float _pace;

    public Biking(string date, float duration, float pace) : base(date, duration)
    {
        _pace = pace;
    }

    public override string DisplaySummary()
    {
        return "";
    }

    public override float GetDistance()
    {
        return 0;
    }

    public override float GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return 0;
    }

    public override float GetPace()
    {
        return _pace;
    }

    public override void AddActivity()
    {
        
    }
}