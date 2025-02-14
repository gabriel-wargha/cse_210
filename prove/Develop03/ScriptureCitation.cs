 using System;
using System.Collections.Generic;
 class  ScriptureCitation {
    private string _book;

    private int _chapter;

    private int _firstVerse;

    private int _lastVerse;

    //Methods 

    public ScriptureCitation(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = verse;
    }

    public ScriptureCitation(string book, int chapter, int FirstVerse, int LastVerse){
        _book = book;
        _chapter = chapter;
        _firstVerse = FirstVerse;
        _lastVerse = LastVerse;
    }

    public void Display (){
        if(_firstVerse == _lastVerse){
            Console.WriteLine($"{_book}, {_chapter}: {_firstVerse}");
        }
        else{
            Console.WriteLine($"{_book}, {_chapter}: {_firstVerse}-{_lastVerse}");
        }
    }

 }