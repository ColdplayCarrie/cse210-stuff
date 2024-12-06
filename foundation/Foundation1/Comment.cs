using System;

public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string name, string text)
    {
        _commenterName = name;
        _commentText = text;
    }

    public string GetName()
    {
        return _commenterName;
    }

    public string GetText()
    {
        return _commentText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_commenterName}: {_commentText}");
    }
}