using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers. Type the number 0 when finished.");
        
            while (userNumber !=0)
            {
                Console.Write("Enter number: ");
                userNumber = int.Parse(Console.ReadLine());

                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
            
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = 0;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is: {max}");

        Console.WriteLine("The End");
    }
}