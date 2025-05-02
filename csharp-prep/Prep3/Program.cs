using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");//

        //ask for magic number//
        Console.WriteLine("What is the magic number? ");
        string userInput = Console.ReadLine();
        int magicNumber = int.Parse(userInput);
        //Console.WriteLine(magicNumber);//

        //Guess the number//
        Console.WriteLine("What is your guess? ");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);
        Console.WriteLine(guess);
    }
}