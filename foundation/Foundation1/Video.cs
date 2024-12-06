using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;


    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    
    public string GetTitle()
    {
        return _title;
    }

        public string GetAuthor()
    {
        return _author;
    }

        public int GetLength()
    {
        return _length;
    }
    public void AddComment(string name, string comment)
    {
        Comment ivy = new Comment(name, comment);
        _comments.Add(ivy);
    }
    public int NumberOfComments()
    {
        int _commentNumber = _comments.Count();
        return _commentNumber;
    }

    public void DisplayComments()
    {
        foreach (var item in _comments)
        {
            item.DisplayComment();
        } 
    }
}