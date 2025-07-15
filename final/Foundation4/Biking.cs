public class Biking : Activity
{
    private float _pace;

    public Biking(string date, string duration, float pace) : base(date, duration)
    {
        _pace = pace;
    }
}