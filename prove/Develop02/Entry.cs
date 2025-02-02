using System.ComponentModel.DataAnnotations;

public class Entry
{

    //Attributes
    public string _prompt;

    public string _entryDateTime;

    public string _entryText;
    
    // Constructor
    public Entry(string prompt, string entryDateTime, string entryText)
    {
        _prompt = prompt;
        _entryDateTime = entryDateTime;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine(_entryText);
    }
}

