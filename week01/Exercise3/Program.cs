using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        //  EXCERSIZE 3 LOOPS
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        // Console.Write("What is your magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());
        int guessNumber = -1;
        int attemps = 0;

        while (magicNumber != guessNumber)
        {
            Console.Write("What is your guess? ");
            guessNumber = int.Parse(Console.ReadLine());

            attemps++;

            if (magicNumber > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guessNumber)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! Attemps:{attemps}.");
            }
        }
    }
}