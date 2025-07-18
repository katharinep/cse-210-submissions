public class Running : Activity
{
    private float _distance;

    public Running(string date, float duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override string DisplaySummary()
    {
        return "";
    }

    public override float GetDistance()
    {
        return _distance;
    }

    public override float GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        float speed = _distance / _duration * 60;
        return speed;
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