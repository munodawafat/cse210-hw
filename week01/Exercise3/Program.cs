using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is your magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random RandomGenerator = new();
        int magicNumber = RandomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;
        

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine($"You guessed it! in {guessCount} guesses");
            }
        }    
    }
}