using System;
using System.Threading;

class Program
{

// 1 verse scripture -------------------------------------------------------------
 private static ScriptureCitation ScriptureCitationNumberOne = new("John", 3, 16);
 private static Verse ScriptureNumberOne = new("For God so loved the world that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life");

 private static List<Verse> verseList = new List<Verse>{ScriptureNumberOne};

 private static ScriptureToMemorize ScriptureToMemorizeNumberOne = new(ScriptureCitationNumberOne, verseList);


// 2 verse scripture
  private static ScriptureCitation ScriptureCitationNumberTwo = new("Proverbs", 3, 5, 6);
 private static Verse ScriptureNumberTwoVerse1 = new("Trust in the Lord with all your heart and lean not on your own understanding");
 private static Verse ScriptureNumberTwoVerse2 = new("in all your ways submit to him, and he will make your paths straight.");

 private static List<Verse> verseListNumberTwo = new List<Verse>{ScriptureNumberTwoVerse1, ScriptureNumberTwoVerse2};

 private static ScriptureToMemorize ScriptureToMemorizeNumberTwo = new(ScriptureCitationNumberOne, verseListNumberTwo);

 

  static void Main(string[] args) {

    while(true){
    Console.Clear();
    ScriptureToMemorizeNumberTwo.Display();

    if(ScriptureToMemorizeNumberTwo.AreAllWordsHidden())
    {
        Console.WriteLine("\nAll words are hidden. Program ending...");
        break;
    }

    Console.WriteLine("Please press Enter to hide random words and 'quit' to exit");
    String user_input = Console.ReadLine();

    if (user_input.ToLower() == "quit"){
        break;
    }
    else if (string.IsNullOrEmpty(user_input)){
        ScriptureToMemorizeNumberTwo.HideThreeRandomWords();
    }

  } 
  }
}   