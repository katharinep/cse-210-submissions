using System;

class Program
{
    static void Main(string[] args)
    {
        //Running Activity 1
        Running running1 = new Running(new DateTime(2025, 7, 1), 24, 5);
        Console.WriteLine(running1.DisplaySummary());
        Console.WriteLine("");

        //Running Activity 2
        Running running2 = new Running(new DateTime(2025, 7, 2), 22, 4);
        Console.WriteLine(running2.DisplaySummary());
        Console.WriteLine("");

        //Swimming Activity 1
        Swimming swimming1 = new Swimming(new DateTime(2025,7,3),21,22);
        Console.WriteLine(swimming1.DisplaySummary());
        Console.WriteLine("");

        //Swimming Activity 2
        Swimming swimming2 = new Swimming(new DateTime(2025,7,4),20,20);
        Console.WriteLine(swimming2.DisplaySummary());
        Console.WriteLine("");

        //Biking Activity 1
        Biking biking1 = new Biking(new DateTime(2025,7,5),65,21);
        Console.WriteLine(biking1.DisplaySummary());
        Console.WriteLine("");

        //Biking Activity 2
        Biking biking2 = new Biking(new DateTime(2025,7,6),72,20);
        Console.WriteLine(biking2.DisplaySummary());
        Console.WriteLine("");
    }
}
//Math Hints:

    //Distance (km) = swimming laps * 50 / 1000
    //Distance (miles) = swimming laps * 50 / 1000 * 0.62
    //***Speed (mph or kph) = (distance / minutes) * 60
   //***Pace (min per mile or min per km)= minutes / distance
    //***Speed = 60 / pace
    //***Pace = 60 / speed
    //Distance = minutes / pace
