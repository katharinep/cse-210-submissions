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
        float distance = _laps * 50 / 1000;
        return distance;
    }

    public override float GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        float distance = GetDistance();
        float speed = distance / _duration * 60; 
        return speed;
    }

    public override float GetPace()
    {
        //Pace = 60 / speed
        float speed = GetSpeed();
        float pace = 60 / speed;
        return pace;
    }

    public override void AddActivity()
    {
        
    }
}