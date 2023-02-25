using System;

public class BreathingActivity : activity{
    
    public BreathingActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity.\n");
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        int seconds = second();
        Console.Clear();
        GetReady();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (startTime < futureTime)
        {
            Console.Write("\nBreathe in...");
            numbers ();

            Console.Write("\nNow breathe out...");
            numbers ();

            startTime = DateTime.Now;
            Console.WriteLine("");
        }

        WellDone(seconds, "Breathing Activity");
    }
}