
class Verse {

    private List<Word> _wordList;
    private static Random _random = new Random();

    //Methods 
    public Verse(string verse)
  {
    _wordList = new List<Word>();
    string[] words = verse.Split(' ');
    foreach (string word in words)
    {
      _wordList.Add(new Word(word));
    }
  }

  public void Display(){

    foreach (Word word in _wordList){
        word.Display();
    }
  }

  public int GetWordCount()
{
    return _wordList.Count;
}

private int GetRevealedCount()
{
    int i = 0;

    foreach (Word word in _wordList)
    {
        if (word.IsRevealed())
        {
            i++;
        }
    }
    return i;
}

public void HideWord(int n){
    if(n>=0 && n < _wordList.Count){
        _wordList[n].hide();
        Thread.Sleep(500);
    }
    
}

public void HideRandomWord(){
    List<int> availableIndexes = new List<int>();

    for(int i = 0; i<_wordList.Count; i++){
        if (_wordList[i].IsRevealed()){
            availableIndexes.Add(i);
        }
    }
    if(availableIndexes.Count > 0){
    int randomIndex = _random.Next(availableIndexes.Count);
    int wordToHide = availableIndexes[randomIndex];
    HideWord(wordToHide);
    }

}

  public bool AreAllWordsHidden(){
        foreach(Word word in _wordList){
            if(word.IsRevealed()){
                return false;
            }
        }
        return true;
    }
}