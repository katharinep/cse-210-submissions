public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {

    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor()
    {
        string color = _color;
    }

    public virtual double GetArea()
    {
        double area = 0;
        return area;
    }

}