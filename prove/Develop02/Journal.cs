using System.Reflection.Metadata.Ecma335;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public string _fileName;

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }
    
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
            entry.Display();
    }
        
    public void SaveToFile(string filename)
    {
        _fileName = filename;
        
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            foreach (Entry item in _entries)
            {
                outputFile.WriteLine($"{item._date}, {item._promptText}, {item._entryText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        _entries = new List<Entry>();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(", ");
            string date = parts[0];
            string prompt = parts[1];
            string answer = parts[2];
            Console.WriteLine($"{date}, {prompt}, {answer}");
            Entry temp = new Entry();

            temp._date = date;
            temp._promptText = prompt;
            temp._entryText = answer;

            _entries.Add(temp);
        } 
    }    
}