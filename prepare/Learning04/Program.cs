using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");//

        Assignment assignment1 = new Assignment("Bob", "Fractions");

        Console.WriteLine(assignment1.GetSummary());

        MathAssignment math1 = new MathAssignment("7.3", "8-19", "Roberto Rodriquez", "Fractions");
        string mathsummary = math1.GetHomeworkList();
        Console.WriteLine(mathsummary);
    }
}