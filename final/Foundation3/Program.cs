using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture Event//
        Lecture lecture1 = new Lecture("How to Tie Your Own Shoes", "Learn how to tie your shoes yourself and gain greater independence.", "October 25, 2025", "3:00 PM", "352 Wallaby Way", "Bob Lowe", "100");

        Console.WriteLine("Standard social media message:");
        Console.WriteLine(lecture1.DisplayStandard());
        Console.WriteLine("");

        Console.WriteLine("Full social media message:");
        Console.WriteLine(lecture1.DisplayFull());
        Console.WriteLine("");

        Console.WriteLine("Short social media message:");
        Console.WriteLine(lecture1.DisplayShort());
        Console.WriteLine("");

        //Reception Event//
        Reception reception1 = new Reception("Goldstein-Forsyth Reception", "Reception for the Goldstein-Forsyth family.", "August 21, 2025", "7:00 PM", "123 Sesame Street", "goldstein.forsyth@email.com");

        Console.WriteLine("Standard social media message:");
        Console.WriteLine(reception1.DisplayStandard());
        Console.WriteLine("");

        Console.WriteLine("Full social media message:");
        Console.WriteLine(reception1.DisplayFull());
        Console.WriteLine("");

        Console.WriteLine("Short social media message:");
        Console.WriteLine(reception1.DisplayShort());
        Console.WriteLine("");

        //Outdoor Event//
        Outdoor outdoor1 = new Outdoor("Bluegrass Concert", "Enjoy local bluegrass groups at an outdoor event with a food truck rally.", "July 30, 2025", "1:00 PM", "Bicentennial Park", "overcast with a slight breeze");

        Console.WriteLine("Standard social media message:");
        Console.WriteLine(outdoor1.DisplayStandard());
        Console.WriteLine("");

        Console.WriteLine("Full social media message:");
        Console.WriteLine(outdoor1.DisplayFull());
        Console.WriteLine("");

        Console.WriteLine("Short social media message:");
        Console.WriteLine(outdoor1.DisplayShort());
        Console.WriteLine("");

    }
}