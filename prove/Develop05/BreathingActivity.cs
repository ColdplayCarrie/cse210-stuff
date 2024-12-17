using System;
using System.Diagnostics;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        
    }

    public void Run()
    {     
        DateTime timer = DateTime.Now;
        DateTime endTime = timer.AddSeconds(GetActivityDuration());
        while (timer < endTime)
        {       
            Console.WriteLine();
            Console.Write("  breathe in ");
            ShowCountDown(5);
            Console.Write("breathe out ");
            ShowCountDown(5);
            Console.WriteLine();
            timer = DateTime.Now;
        } 
    }
}