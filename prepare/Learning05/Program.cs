using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("Bob Bobberton", "American Sign Language");
        Console.WriteLine(assignment1.GetSummary());

        MathAssignment mathAssignment1 = new MathAssignment("Rob Robberton", "British Sign Language", "Section 7.3", "Problems 10-23");
        Console.WriteLine($"{mathAssignment1.GetSummary()}, {mathAssignment1.GetHomeworkList()}");

        WritingAssignment writingAssignment1 = new WritingAssignment("Bab Babberton", "Computer Science Language", "Is C# as Difficult as I'm Making It?");
        Console.WriteLine($"{writingAssignment1.GetSummary()}, {writingAssignment1.GetWritingInformation()}");
    }
}