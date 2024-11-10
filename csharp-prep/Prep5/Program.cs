using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int square = SquareNumber();

        Console.WriteLine($"{userName}, the square of your number is {square}.");

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int favNumber = int.Parse(Console.ReadLine());
            return favNumber;
        }

        static int SquareNumber()
        {
            int favNumber = PromptUserNumber();
            int square = favNumber * favNumber;
            return square;
        }

    }
}