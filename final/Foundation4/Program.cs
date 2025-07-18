using System;

class Program
{
    static void Main(string[] args)
    {
        //Running Activity 1
        Running running1 = new Running(new DateTime(2025, 7, 1), 24, 5);

        //Running Activity 2
        Running running2 = new Running(new DateTime(2025, 7, 2),22,4);

        //Swimming Activity 1

        //Swimming Activity 2

        //Biking Activity 1

        //Biking Activity 2

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
