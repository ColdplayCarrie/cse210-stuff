using System;
using System.Data;
using System.Runtime.CompilerServices;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string _wholeReference;

        if (_endVerse == 0)
        {
            _wholeReference = $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            _wholeReference = $"{_book} {_chapter}:{_verse}-{_endVerse}"; 
        }
        return _wholeReference;
    }
}