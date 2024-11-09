using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string userGradePercentage = Console.ReadLine();
        int gradePercentageNumber = int.Parse(userGradePercentage);

        string letter = "";

        if (gradePercentageNumber >= 90)
        {
            letter = "A";
        }
        else if (gradePercentageNumber >= 80)
        {
            letter = "B";
        }
        else if (gradePercentageNumber >= 70)
        {
            letter = "C";
        }
        else if (gradePercentageNumber >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}.");
        
            if (gradePercentageNumber >=70)
            {
                Console.Write("Congratulations! You passed!");
            }
            else
            {
                Console.Write("You didn't pass yet. Try again! You'll get it!");
            }
    }    
}