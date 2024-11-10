using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("Guess the magic number: ");
            guess = int.Parse(Console.ReadLine());
            
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }

            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }

            else
            {
                Console.Write("Wow! You guessed the magic number!!");
            }
        }
    }
}