class ScriptureToMemorize
{

    private ScriptureCitation _reference;
    private List<Verse> _verses;


    //Constructor

    public ScriptureToMemorize( ScriptureCitation reference, List<Verse> verses){
        _reference = reference;
        _verses = new List<Verse>();

        foreach (Verse verse in verses)
        {
            _verses.Add(verse);
        }
    }

    public void Display(){
        _reference.Display();
        Console.WriteLine("");
        foreach (Verse verse in _verses){
            verse.Display();
            Console.WriteLine();
            
        }
    }

    public void HideThreeRandomWords(){
        Random r = new Random();


        for(int i = 0; i<3; i++){

            int verseIndex = r.Next(_verses.Count);
            Verse randomVerse = _verses[verseIndex];
            randomVerse.HideRandomWord();    

        }
        

    }

    public bool AreAllWordsHidden(){
        foreach(Verse verse in _verses){
            if(!verse.AreAllWordsHidden()){
                return false;
            }
        }
        return true;
    }


}