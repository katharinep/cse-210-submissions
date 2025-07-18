public class Biking : Activity
{
    private double _pace;

    public Biking(string date, double duration, double pace) : base(date, duration)
    {
        _pace = pace;
    }

    public override string DisplaySummary()
    {
        return "";
    }

    public override double GetDistance()
    {
        return 0;
    }

    public override double GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return 0;
    }

    public override double GetPace()
    {
        return _pace;
    }

    public override void AddActivity()
    {
        
    }
}