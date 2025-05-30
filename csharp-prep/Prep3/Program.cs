using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");//
        
        bool playAgain = true;
        bool game = true;
        int count = 0;
        
        //ask for magic number//
        //Console.WriteLine("What is the magic number?");
        //string userInput = Console.ReadLine();
        //int magicNumber = int.Parse(userInput);
        //Console.WriteLine(magicNumber);//

        while (playAgain == true)
        {
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
                count = count + 1;

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
                    if (count == 1)
                    {
                        Console.WriteLine("You guessed in one try!");
                    }
                    else
                    {
                        Console.WriteLine($"You guessed in {count} tries!");
                    }
                }
            }
             
            //Ask to play again//
            Console.WriteLine("Would you like to play again? (yes/no)");
            string playResponse = Console.ReadLine();
            if (playResponse == "yes")
            {
                playAgain = true;
            }
            else if (playResponse == "no")
            {
                playAgain = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid response.");
            }
        }
    }
}