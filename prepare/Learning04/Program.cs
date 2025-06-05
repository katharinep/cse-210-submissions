using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");//

        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Bob");
        assignment1.SetTopic("Fractions");

        Console.WriteLine(assignment1.GetSummary());
    }
}