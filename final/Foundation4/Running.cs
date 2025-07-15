public class Running : Activity
{
    private float _distance;

    public Running(string date, string duration, float distance) : base(date, duration)
    {
        _distance = distance;
    }
}