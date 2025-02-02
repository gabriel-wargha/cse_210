using System;
using System.Collections.Generic;

public class Journal
{
    // Private field
    public List<Entry> _entryList;

    // Constructor
    public Journal()
    {
        _entryList = new List<Entry>();
    }

    // Public method to append an entry
    public void AppendEntry(Entry entry)
    {
        _entryList.Add(entry);
    }

    public void Display()
    {
        foreach (Entry entry in _entryList)
        {
            Console.WriteLine(entry._entryDateTime);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._entryText);
        }
    }
}