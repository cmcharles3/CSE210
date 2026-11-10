using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    // Adds a new entry to the list
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // Loops through all entries and displays them
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("The journal is empty.");
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    // Saves the journal to a file
    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                // We use a | to separate the data because it's unlikely to be typed in a normal journal
                outputFile.WriteLine($"{entry._date}|{entry._promptText}|{entry._entryText}");
            }
        }
        Console.WriteLine("Journal saved successfully.");
    }

    // Loads the journal from a file
    public void LoadFromFile(string file)
    {
        string[] lines = System.IO.File.ReadAllLines(file);
        
        // Clear current entries before loading new ones
        _entries.Clear(); 

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");

            if (parts.Length == 3) // Make sure the line has all 3 parts
            {
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[2];

                _entries.Add(loadedEntry);
            }
        }
        Console.WriteLine("Journal loaded successfully.");
    }
}
