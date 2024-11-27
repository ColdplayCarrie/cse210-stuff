using System;

public class Word
{
    private string _word;
    private bool _isVisible;

    public Word(string word)
    {
        _word = word;
        _isVisible = true;
    }

    public void Hide()
    {
        _isVisible = false;
    }

    public void Show()
    {
        _isVisible = true;
    }

    public bool IsVisible()
    {
        return _isVisible;
    }

    public string GetDisplayText()
    {
        if (_isVisible == true)
        {
            return _word;
        }
        else
        {
            int length = _word.Length;
            string temp = "";
            for (int i = 0; i < length; i++)
            {
                temp = temp+"_";
            }
            return temp;
        }
    }
}