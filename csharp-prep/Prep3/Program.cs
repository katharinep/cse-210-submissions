using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");//

        bool game = true;
        //ask for magic number//
        //Console.WriteLine("What is the magic number?");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse(userInput);
        //Console.WriteLine(magicNumber);//

        //random number//
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        //while loop for guesses//
        while (game == true)
        {
            //Guess the number//
            Console.WriteLine("What is your guess? (1-100)");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);
            //Console.WriteLine(guess);//

            //if statement comparing numbers//
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
                game = false;
            }
        }
    }
}