using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry) // AddEntry function
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll() // DisplayAll function
    {
        foreach (Entry element in _entries)
        {
            element.Display();
        }
    }
    public void SaveToFile(string file) // SaveToFile function
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry element in _entries)
            {
                outputFile.WriteLine($"{element._date} | {element._promptText} | {element._entryText}");
            }
        }
    }
    public void LoadFromFile(string file) // LoadFromFile function
    {
        _entries.Clear();

        string[] lines = System.IO.File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
        
            Entry newEntry = new Entry();

            newEntry._date = parts[0];
            newEntry._promptText = parts[1];
            newEntry._entryText = parts[2];

            _entries.Add(newEntry);

        }

    }

}