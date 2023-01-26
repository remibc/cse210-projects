using System;
using System.IO;

public class Prompt{
    public string _question;
    public string _answers;
    public string _dateText;
    
    public void questions(int mnumber)
    {
        switch (mnumber)
        {
            case 1:
                _question = "Who was the most interesting person I interacted with today?";
            break;
            case 2:
                _question = "What was the best part of my day?";
            break;
            case 3:
                _question = "How did I see the hand of the Lord in my life today?";
            break;
            case 4:
                _question = "What was the strongest emotion I felt today?";
            break;
            case 5:
                _question = "If I had one thing I could do over today, what would it be?";
            break;
        }
        Console.WriteLine($"\n{_question}");
    }

}