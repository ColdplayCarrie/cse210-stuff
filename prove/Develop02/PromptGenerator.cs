using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was your favorite part of today? Why?",
        "Think of a person in your life. How have they affected you?",
        "What did you do this morning?",
        "What are you going to do tomorrow?",
        "Mountains or beaches? Why?",
        "What is your favorite thing to drink? Why is it your favorite?",
        "What is a song that you love? Why do you love that song?",
        "What is a quote that you love? Why do you love that quote?",
        "Morning or Evening? Why?",
        "You matter to someone. Who matters to you? Why do they matter to you?",
        "What is one of your favorite scriptures? What do you love about it?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

}    