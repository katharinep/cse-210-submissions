public class Square : Shape
{
    private double _side;
    public Square(string color, double side) : base(color)
    {

    }

    public override double GetArea()
    {
        double area = _side * _side;
        return area;
    }
}