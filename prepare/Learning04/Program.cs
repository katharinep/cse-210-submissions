using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");//

        Assignment assignment1 = new Assignment("Bob", "Fractions");

        Console.WriteLine(assignment1.GetSummary());
    }
}