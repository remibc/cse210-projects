using System;

public class Video : Comments
{
    private string _Title;
    private string _Author;
    private int _Length;
    private string _Comment;

    public Video()
    {
        Console.Clear();
        Console.WriteLine("***Video***");
        Console.Write("Video Name: ");
        _Title = Console.ReadLine();
        Console.Write("Videos Author: ");
        _Author = Console.ReadLine();
        Console.Write("Duration: ");
        _Length = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        _Comment = AddComments();
    }
    public Video(string Title, string Author, int Length, string Comment)
    {
        _Title = Title;
        _Author = Author;
        _Length = Length;
        _Comment = Comment;
    }
    public string Title()
    {
        return _Title;
    }
    public string Author()
    {
        return _Author;
    }
    public int Length()
    {
        return _Length;
    }
    public string[] Display()
    {
        string[] display = _Comment.Split('|');
        return display;
    }

    public string Comment()
    {
        return _Comment;
    }
    
}