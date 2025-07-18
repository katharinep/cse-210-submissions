public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, double duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    
    public override string DisplaySummary()
    {
        return $"{_date.ToString("dd MMM yyyy")} Swimming - Duration: {_duration} minutes, Laps: {_laps}, Distance: {GetDistance():2} km, Speed: {GetSpeed():2} kmh, Pace: {GetPace():2} min per km"; ;
    }

    public override double GetDistance()
    {
        //Distance (km) = swimming laps * 50 / 1000
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        //Speed (mph or kph) = (distance / minutes) * 60
        double distance = GetDistance();
        double speed = distance / _duration * 60; 
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