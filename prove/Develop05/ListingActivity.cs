using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity(string name, string description, int duration, int count) : base(name, description, duration)
    {
        _count = count;
        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"  
        };
    }

    public void Run()
    {
        Console.WriteLine();
        Console.WriteLine("Enter as many things as you can pertaining to the prompt.");
        Console.WriteLine("Hit the enter key after each item you list.");
        Console.WriteLine();
        Thread.Sleep(2000);
        Console.WriteLine($"Reflect on this prompt: ");
        GetRandomPrompt();
        Console.Write("Get ready");
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine("Start listing!");
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count} things.");
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine($"---> {prompt}");
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        
        DateTime timer = DateTime.Now;
        DateTime endTime = timer.AddSeconds(GetActivityDuration());
        
        do
        {
            string input = Console.ReadLine();
            userList.Add(input);
            timer = DateTime.Now;
        }while (timer < endTime);
        
        return userList;
    }
}