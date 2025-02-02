using System;
using System.Collections.Generic;
using System.IO;

class Program
{
  private static Journal currentJournal = new(); // Ensure it's always initialized

  static void Main()
  {
    MenuLoop();
  }

  static void MenuLoop()
  {
    string answer;

    do
    {
      Console.WriteLine("Please select one of the following choices");
      Console.WriteLine("1. Write");
      Console.WriteLine("2. Display");
      Console.WriteLine("3. Load");
      Console.WriteLine("4. Save");
      Console.WriteLine("5. Quit");
      answer = Console.ReadLine();
      List<char> validAnswers = new() { '1', '2', '3', '4', '5' };

      if (answer.Length > 1 || !validAnswers.Contains(answer[0]))
      {
        Console.WriteLine("Please select a valid answer");
        continue;
      }

      switch (answer)
      {
        case "1":
          WriteNewEntry();
          break;

        case "2":
          currentJournal.Display();
          break;

        case "3":
          LoadJournalFile();
          break;

        case "4":
          SaveJournalFile();
          break;

        case "5":
          Console.WriteLine("Goodbye!");
          break;

        default:
          Console.WriteLine("Invalid choice.");
          break;
      }

    } while (answer != "5");
  }

  static void WriteNewEntry()
  {
    Prompt newPrompt = new();
    string prompt = newPrompt.GeneratePrompt();
    Console.WriteLine(prompt);
    string entryText = Console.ReadLine();

    Entry newEntry = new(prompt, DateTime.Now.ToString(), entryText);
    currentJournal.AppendEntry(newEntry);
  }

  static void SaveJournalFile()
  {
    Console.WriteLine("Enter the file name without the extension (it will be saved as a CSV file): ");
    string fileName = Console.ReadLine();

    if (!fileName.EndsWith(".csv"))
    {
      fileName += ".csv";
    }

    string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

    using (StreamWriter outputFile = new(filePath))
    {
      foreach (Entry entry in currentJournal._entryList)
      {
        outputFile.WriteLine($"{entry._entryDateTime},{entry._prompt}, {entry._entryText}");
      }
    }

    Console.WriteLine($"Journal saved successfully at: {filePath}");
  }

  static void LoadJournalFile()
  {
    Console.WriteLine("Enter the file name without the extension (it should be a CSV file): ");
    string fileName = Console.ReadLine();

    if (!fileName.EndsWith(".csv"))
    {
      fileName += ".csv";
    }

    string filePath = Path.Combine(Environment.CurrentDirectory, fileName);

    if (!File.Exists(filePath))
    {
      Console.WriteLine("File not found.");
      return;
    }

    string[] lines = File.ReadAllLines(filePath);

    foreach (string line in lines)
    {
      string[] entryData = line.Split(',');
      Entry newEntry = new(entryData[1], entryData[0], entryData[2]);
      currentJournal.AppendEntry(newEntry);
    }

    Console.WriteLine($"Journal loaded successfully from: {filePath}");
  }
}