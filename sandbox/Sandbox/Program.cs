using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelect = 0;
        do
        {    
            Console.WriteLine("Which type of Goal would you like to create?");
            userSelect = int.Parse(Console.ReadLine());
            if (userSelect == 1)
            {
                Console.WriteLine("What is the name of your goal?");
                string _shortName = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string _description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                int _points = int.Parse(Console.ReadLine());
                SimpleGoal simpleGoal = new SimpleGoal(_shortName,_description,_points);
                _goals.Add(simpleGoal);
            }
            else if (userSelect == 2)
            {
                Console.WriteLine("What is the name of your goal?");
                string _shortName = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string _description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                int _points = int.Parse(Console.ReadLine());
                EternalGoal eternalGoal = new EternalGoal(_shortName,_description,_points);
                _goals.Add(eternalGoal);
            }
            else if (userSelect == 3)
            {
                Console.WriteLine("What is the name of your goal?");
                string _shortName = Console.ReadLine();
                Console.WriteLine("What is a short description of your goal?");
                string _description = Console.ReadLine();
                Console.WriteLine("What is the amount of points associated with this goal?");
                int _points = int.Parse(Console.ReadLine());
                Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
                int _target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the bonus for accomplishing it that many times?");
                int _bonus = int.Parse(Console.ReadLine());
                ChecklistGoal checklistGoal = new ChecklistGoal(_shortName,_description,_points,0,_target,_bonus);
                _goals.Add(checklistGoal);
            }
            else if (userSelect >=4)
            {
                Console.WriteLine("Please enter 1, 2, or 3");
            }
        }while (userSelect <=3);

    }
}