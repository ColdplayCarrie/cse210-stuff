using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _prompts = new List<string>()
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>()
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
    }

    public void Run()
    {
        Console.WriteLine();
        DisplayPrompt();
        ShowCountDown(5);
        Console.WriteLine();
        Console.WriteLine("Now reflect on the following questions relating to this experience.");
        Console.WriteLine();
        Thread.Sleep(2000);

        DateTime timer = DateTime.Now;
        DateTime endTime = timer.AddSeconds(GetActivityDuration());
        while (timer < endTime)
        {
            DisplayQuestion();
            ShowSpinner(8);
            timer = DateTime.Now;
        }
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        return prompt;
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        string question = _questions[random.Next(_questions.Count)];
        return question;
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"---> {prompt}");
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine($"---> {question}");
    }
}