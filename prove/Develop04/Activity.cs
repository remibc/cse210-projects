using System;

public class activity{
    public void GetReady()
    {
        Console.Write("Get Ready....\n");
        clock();
        Console.WriteLine("");
    }

    public void WellDone(int time, string activity)
    {
        Console.WriteLine("\nWell Done!!");
        clock();
        Console.WriteLine($"\n\nYou have completed another {time} seconds of the {activity}");
        clock();
        Console.WriteLine("");
    }

    public int second()
    {
        Console.Write("How Long, in seconds, would you like for your session? ");
        string sec = Console.ReadLine();
        int seconds = int.Parse (sec);
        return seconds;
    }

    public void clock()
    {
        int x = 0;
        while (x<10)
        {
            Console.Write("-");        
            Thread.Sleep(300);

            Console.Write("\b \b");
            Console.Write(">"); 

            x=x+1;
        }
    }
    public void numbers ()
    {
        int x=4;
        while (x != 0)
        {
            Console.Write(x);
            Thread.Sleep(1000);
            x = x-1;
            Console.Write("\b \b");
        }
    }
}
