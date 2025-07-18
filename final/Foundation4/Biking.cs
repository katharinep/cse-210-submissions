public class Biking : Activity
{
    private double _speed;

    public Biking(DateTime date, double duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }

    public override string DisplaySummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Biking - Duration: {_duration} minutes, Distance: {GetDistance():2} km, Speed: {GetSpeed():2} kmh, Pace: {GetPace():2} min per km";
    }

    public override double GetDistance()
    {
        return 0;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        //Pace = 60 / speed
        double pace = 60 / _speed;
        return pace;
    }
}