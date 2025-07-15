public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, string duration, int laps) : base(date, duration)
    {
        _laps = laps;
    }
    
}