

class Word {

    private string _word;
    private bool _revealed;


    //Methods 
    
    public Word (string s){
        _word = s;
        _revealed = true;
    }

    public void Display() {
        if (_revealed){
        Console.Write(_word + " ");
        }
        else {
            Console.Write("----- ");
        }
    }

    public string getWord(){
        return _revealed ? _word : "-----";
    }


    public void hide(){
        _revealed = false;
    }

    public bool IsRevealed(){
        return _revealed;
    }


}