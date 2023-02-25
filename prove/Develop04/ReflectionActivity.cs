using System;
using System.IO;

public class ReflectionActivity : activity{

    private string _question;
    
    public ReflectionActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life\n");
        int seconds = second();
        Console.Clear();
        GetReady(); 

        Random randomGenerator = new Random();
        int mnumber = randomGenerator.Next(1,4);

        switch (mnumber)
        {
            case 1:
                _question = "Think of a time when you stood up for someone else.";
            break;
            case 2:
                _question = "Think of a time when you did something really difficult.";
            break;
            case 3:
                _question = "Think of a time when you helped someone in need.";
            break;
            case 4:
                _question = "Think of a time when you did something truly selfless.";
            break;
        }

        Console.WriteLine($"\nConsider the following prompt: \n\n\t****** {_question} ******");

        Console.WriteLine($"\nWhen you have something in mind, press enter to continue");
        Console.ReadLine();

        Console.WriteLine($"Now ponder on each of the following questions as they related to this experience.");

        Console.Write($"You may begin in: ");
        numbers();

        Console.Clear();
        
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (startTime < futureTime)
        {
            randomGenerator = new Random();
            mnumber = randomGenerator.Next(1,9);
            switch (mnumber)
            {
                case 1:
                    _question = "Why was this experience meaningful to you?";
                break;
                case 2:
                    _question = "Have you ever done anything like this before?";
                break;
                case 3:
                    _question = "How did you get started?";
                break;
                case 4:
                    _question = "How did you feel when it was complete?";
                break;
                case 5:
                    _question = "What made this time different than other times when you were not as successful?";
                break;
                case 6:
                    _question = "What is your favorite thing about this experience?";
                break;    
                case 7:
                    _question = "What could you learn from this experience that applies to other situations?";
                break; 
                case 8:
                    _question = "What did you learn about yourself through this experience?";
                break; 
                case 9:
                    _question = "How can you keep this experience in mind in the future?";
                break;                 
            }
            Console.WriteLine($"-> {_question}");
            clock();
            Console.WriteLine("");
            startTime = DateTime.Now;
        }

        WellDone(seconds, "Reflection Activity");
    }

}