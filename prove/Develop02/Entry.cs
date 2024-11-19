using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;  
    public void Display()
    {
        Console.WriteLine($"DATE OF ENTRY: {_date}");
        Console.WriteLine($"    PROMPT: {_promptText}");
        Console.WriteLine($"    ANSWER: {_entryText}");
        Console.WriteLine("");
    }
}