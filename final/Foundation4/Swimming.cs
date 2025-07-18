public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, float duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    
    public override string DisplaySummary()
    {
        return "";
    }

    public override float GetDistance()
    {
        //Distance (km) = swimming laps * 50 / 1000
        return 0;
    }

    public override float GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        return 0;
    }

    public override float GetPace()
    {
        //Pace = 60 / speed
        return 0;
    }

    public override void AddActivity()
    {
        
    }
}