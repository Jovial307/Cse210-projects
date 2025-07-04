using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        int noOfGuesses = 1;
        string replay = "yes";
        while (replay == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1;

            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string userInput2 = Console.ReadLine();
                guess = int.Parse(userInput2);


                if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    noOfGuesses += 1;
                }
                else if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    noOfGuesses += 1;
                }
                else
                {
                    Console.WriteLine("You guessed it.");
                    Console.WriteLine($"You guessed it in {noOfGuesses} tries.");
                }
            }
            Console.Write("Do you want to play again? ");
            replay = Console.ReadLine();
        }
    }
}