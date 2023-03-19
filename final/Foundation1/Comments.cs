using System;
public class Comments
{
    private string _Comment;
    private string _Person;
    public string AddComments ()
    {
        string c = "";

        while (c.ToUpper() != "N")
        {
            Console.WriteLine("***Comments***");
            Console.Write("Person: ");
            _Person = Console.ReadLine();
            Console.Write("Comment: ");
            _Comment = _Comment + _Person +":"+ Console.ReadLine() + "|";
            Console.Write("Add new Comment (Y/N): ");
            c = Console.ReadLine();
        }
        return _Comment;  
    }
    
}