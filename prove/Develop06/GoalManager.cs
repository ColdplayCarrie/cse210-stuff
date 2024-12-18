using System;
using System.IO;
using System.IO.Compression;

public class GoalManager
{
    private List<Goal> _goals;
    private int _score = 0;

    public GoalManager()
    {
        _goals = new List<Goal>();
    }

    //the "main" function for this class, called by Program.cs, and then runs the menu loop
    public void Start()
    { 
        int userSelect = 0;
        DisplayPlayerInfo();
        do
        {
            Console.WriteLine("Menu Options");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.WriteLine();
            Console.Write("Select a choice from the menu: ");
            userSelect = int.Parse(Console.ReadLine());

            if (userSelect == 1)
            {
                ListGoalNames();
                CreateGoal();
            }
            else if (userSelect == 2)
            {
                ListGoalDetails();
            }
            else if (userSelect == 3)
            {
                SaveGoals();
            }
            else if (userSelect == 4)
            {
                LoadGoals();
            }
            else if (userSelect == 5)
            {
                ListGoalDetails();
                RecordEvent();
            }

            DisplayPlayerInfo();

        } while (userSelect != 6);
        if (userSelect == 6)
        {
            Console.WriteLine();
            Console.WriteLine("Bye now!");
            Console.WriteLine();
        }
    }

    //displays player's current score
    public void DisplayPlayerInfo()
    {
        Console.WriteLine();
        Console.Write("You have ");
        ShowCountDown(3);
        Console.WriteLine(" " + _score + " points!");
        Console.WriteLine();
        Thread.Sleep(1500);
    }

    //lists the names of each of the goals
    public void ListGoalNames()
    {
        Console.WriteLine();
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
    }

    //lists the details of each goal including the checkbox
    public void ListGoalDetails()
    {
        Console.WriteLine();
        Console.WriteLine("Your goals are:");
        for(int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + _goals[i].GetDetailsString());
        }
        Console.WriteLine();
    }

    //asks the user for information about a new goal, creates the goal, and adds it to the list
    public void CreateGoal()
    {
        int userSelect = 0; 
        ListGoalDetails();
        Console.WriteLine("Which type of Goal would you like to create? (4 to exit)");
        userSelect = int.Parse(Console.ReadLine());
        Console.WriteLine();
        if (userSelect == 1)
        {
            Console.WriteLine("What is the name of your goal?");
            string _shortName = Console.ReadLine();
            Console.WriteLine("What is a short description of your goal?");
            string _description = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal?");
            int _points = int.Parse(Console.ReadLine());
            SimpleGoal simpleGoal = new SimpleGoal(_shortName,_description,_points, false);
            _goals.Add(simpleGoal);
        }
        else if (userSelect == 2)
        {
            Console.WriteLine();
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
            Console.WriteLine();
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
            ChecklistGoal checklistGoal = new ChecklistGoal(_shortName,_description,_points,_target,_bonus,0);
            _goals.Add(checklistGoal);
            }
            else if (userSelect >=4)
            {
                Console.WriteLine("Please enter 1, 2, or 3");
            }
    }

    //asks user which goal they have done and records the event by calling the RecordEvent method on that goal
    public void RecordEvent()
    {
        Console.WriteLine();
        Console.WriteLine("Which goal have you completed?");
        int _userGoalComplete = int.Parse(Console.ReadLine());
        _score += _goals[_userGoalComplete - 1].RecordEvent();
    }

    //saves the list of goals to a file
    public void SaveGoals()
    { 
        Console.WriteLine();
        Console.WriteLine("What is the name of the file (including the file extension .txt)?");
        string userFileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(userFileName))
        {
            outputFile.WriteLine(_score);
            foreach (Goal line in _goals)
            {
                outputFile.WriteLine(line.GetStringRepresentation());
            }
        }
   }

    //loads the list of goals from a file
    public void LoadGoals()
    {
        Console.WriteLine();
        Console.WriteLine("What is the name of the file (including the file extension .txt) for the goal file?");
        string userFileName = Console.ReadLine();
        
        string[] lines = System.IO.File.ReadAllLines(userFileName);

        for (int i = 0; i < lines.Length; i++)
        {
            if (i == 0)
            {
                _score = int.Parse(lines[i]);
            }
            else
            {
                string[] parts = lines[i].Split(":");
                string[] goalSplit = parts[1].Split(",");

                Goal currentGoal;

                if (parts[0].Equals("SimpleGoal"))
                {
                    currentGoal = new SimpleGoal(goalSplit[0], goalSplit[1], int.Parse(goalSplit[2]), bool.Parse(goalSplit[3]));
                }
                else if (parts[0].Equals("EternalGoal"))
                {
                    currentGoal = new EternalGoal(goalSplit[0], goalSplit[1], int.Parse(goalSplit[2]));
                }
                else
                {
                    currentGoal = new ChecklistGoal(goalSplit[0], goalSplit[1], int.Parse(goalSplit[2]), int.Parse(goalSplit[3]), int.Parse(goalSplit[4]), int.Parse(goalSplit[5]));
                }

                _goals.Add(currentGoal);
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(". ");
            Thread.Sleep(1000);
        }
    }
}