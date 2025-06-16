using System;

class Program
{
    static void Main(string[] args)
    {
        Shape square = new Square("blue", 2);
        double squarearea = square.GetArea();
        string squarecolor = square.GetColor();
        Console.WriteLine(squarearea);
        Console.WriteLine(squarecolor);

        Shape rectangle = new Rectangle(4, 2, "red");
        double recarea = rectangle.GetArea();
        string reccolor = rectangle.GetColor();
        Console.WriteLine(recarea);
        Console.WriteLine(reccolor);

        Shape circle = new Circle(1, "yellow");
        double circlearea = circle.GetArea();
        string circlecolor = circle.GetColor();
        Console.WriteLine(circlearea);
        Console.WriteLine(circlecolor);
    }
}