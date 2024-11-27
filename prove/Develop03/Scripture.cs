using System;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string sText)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitText = sText.Split(" ");
        for (int i = 0; i < splitText.Length; i++)
        {
            string text = splitText[i];
            Word word = new Word(text);
            _words.Add(word);
        }
    }

    public void HideRandomWords(int num)
    {
        Random random = new Random();
        

        for (int i = 0; i < num; i++)
        {
            int randomIndex = random.Next(_words.Count);
            _words[randomIndex].Hide();
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " "; 
        }
        return $"{displayText.Trim()}";
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsVisible())
            {
                return false;
            }
        }
        return true;
    }
}