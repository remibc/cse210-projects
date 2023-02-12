using System;

public class reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private string _verseInfo;

    public reference()
    {
        _book = "Proverbs";
        _chapter = "3";
        _verse = "5";
        _verseInfo = "Trust in the LORD with all your heart and lean not on your own understanding";
    }

    public reference(string test)
    {
        _book = "Proverbs";
        _chapter = "3";
        _verse = "5";
        _verseInfo = test;
    }
    //This constructor helps to print the scripture from a TXT file in the program
    public reference(string book, string chapter, string verse, string verseInfo)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _verseInfo = verseInfo;
    }

    public string verse2()
    {
        string print = _verseInfo;
        return print;
    }

    public string print()
    {
        string print = $"{_book} {_chapter}:{_verse} {_verseInfo}";
        return print;
    }
}