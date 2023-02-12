using System;
using System.IO;

public class scripture
{
    private string _sentence;
    private int _x;
    private int _y;
    public scripture()
    {
        reference verse = new reference();
        string[] scripture = verse.verse2().Split(' ');
        _x=0;

        while (_x < 3)
        {
            word r = new word(scripture);
            scripture[r.selectWord()] = "_____";
            _x=_x+1;
        }

        _sentence = "";
        foreach (var sentence in scripture)
        {
            if (_sentence == ""){
                _sentence = sentence;
            }
            else {
                _sentence = _sentence +" "+ sentence;
            }
            
        }
    }

    public scripture(string test)
    {
        reference verse = new reference(test);
        string[] scripture = verse.verse2().Split(' ');
        
        _x=0;
        while (_x<3)
        {
            word r = new word(scripture);
            scripture[r.selectWord()] = "_____";
            _x=_x+1;
        }
        _sentence = "";
        foreach (var sentence in scripture)
        {
            if (_sentence == ""){
                _sentence = sentence;
            }
            else {
                _sentence = _sentence +" "+ sentence;
            }
        }
    }
    //This Constructor will help to hide words and print the scripture from the TXT file
    public scripture(string test1, string test2,string test3,string test4)
    {
        reference verse = new reference(test1,test2,test3,test4);
        string[] scripture = verse.verse2().Split(' ');
        
        if (scripture.Length%2 == 1)
        {
            _y=3;
        }
        else{
            _y=2;
        }

        _x=0;
        while (_x<_y)
        {
            word r = new word(scripture);
            scripture[r.selectWord()] = "_____";
            _x=_x+1;
        }
        _sentence = "";
        foreach (var sentence in scripture)
        {
            if (_sentence == ""){
                _sentence = sentence;
            }
            else {
                _sentence = _sentence +" "+ sentence;
            }
        }
    }

    public string print()
    {
        string sentence2 = _sentence;
        return sentence2;
    }

}
