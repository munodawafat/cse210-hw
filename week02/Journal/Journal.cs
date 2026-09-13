using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
   
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }
    
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                string line = $"{entry._date}{'|'}{entry._promptText}{'|'}{entry._entryText}";
                writer.WriteLine(line);
            }
        }
        Console.WriteLine("Entries saved to file: " + filename);
    }
    public void LoadFromFile(string filename)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                string date = parts[0];
                string promptText = parts[1];
                string entryText = parts[2];
                Entry entry = new Entry(date, promptText, entryText);
                _entries.Add(entry);
            }
        }
        Console.WriteLine("Entries loaded successfully.");
        Console.WriteLine("Total entries loaded: " + _entries.Count);
    }
}