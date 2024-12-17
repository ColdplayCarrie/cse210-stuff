using System;
using System.ComponentModel;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetActivityName()
    {
        return _name;
    }

    public string GetActivityDescription()
    {
        return _description;
    }

    public int GetActivityDuration()
    {
        return _duration;
    }
    
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine("Enter how many seconds you would like to spend on this activity: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prepare to begin the {_name} Activity.");
        Thread.Sleep(2000);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You did great!");
        ShowSpinner(2);
        Console.WriteLine();
        Console.WriteLine($"You completed the {_name} Activity over the course of {_duration}+ seconds.");
        ShowSpinner(3);
        Console.WriteLine();
        Console.WriteLine("Well done! Come back again soon. :)");
        Console.WriteLine();
        Thread.Sleep(2000);
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach (string a in animation)
        {
            Console.Write(a);
            Thread.Sleep(300);
            Console.Write("\b \b");
        }

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < end)
        {
            string a = animation[i];
            Console.Write(a);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
        //Code ready just in case I want to do the countdown this way
        //Console.Write(i);
        //Thread.Sleep(1000);
        //Console.Write("/b /b");

        Console.Write(". ");
        Thread.Sleep(1000);
        }        
    }
}