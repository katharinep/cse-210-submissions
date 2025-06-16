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
    }
}