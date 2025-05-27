using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Fraction Calculator");
        Console.Write("Enter the top number: ");
        string userTop = Console.ReadLine();
        int top = int.Parse(userTop);

        Console.Write("Enter the bottom number: ");
        string userBottom = Console.ReadLine();
        int bottom = int.Parse(userBottom);

        if (bottom == 1)
        {
            Fraction wholeFraction = new Fraction(top);

        }
        else if (bottom == 1 & top == 1)
        {
            Fraction defaultOne = new Fraction();
        }
        else
        {
            Fraction fraction = new Fraction(top, bottom);
        }
    }
}