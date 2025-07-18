public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, double duration, double distance) : base(date, duration)
    {
        _distance = distance;
    }

    public override string DisplaySummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Running - Duration: {_duration} minutes, Distance: {GetDistance():2} km, Speed: {GetSpeed():2} kmh, Pace: {GetPace():2} min per km";
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
}