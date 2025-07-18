public class Running : Activity
{
    private double _distance;

    public Running(string date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override string DisplaySummary()
    {
        return $"Running - Duration: {_duration} minutes, Distance: {_distance:2f} km, Speed: {GetSpeed():2f}kmh, Pace: {GetPace():2f}";
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        double speed = _distance / _duration * 60;
        return speed;
    }

    public override double GetPace()
    {
        //Pace = 60 / speed
        double speed = GetSpeed();
        double pace = 60 / speed;
        return pace;
    }

    public override void AddActivity()
    {
        
    }
}