using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Running running = new Running("06 Jun 2024", 23, 3);
        Console.WriteLine(running.GetSummary());
        

        Cycling cycling = new Cycling("24 Sep 2023", 30, 30);
        Console.WriteLine(cycling.GetSummary());


        Swimming swimming = new Swimming("13 Aug 2004", 60, 25);
        Console.WriteLine(swimming.GetSummary());
        Console.WriteLine();
    }
}