using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int mnumber = randomGenerator.Next(1, 100);

        Console.Write("What is your guess? ");
        string number2 = Console.ReadLine();
        int guess = int.Parse (number2);

        int x = 0;

        while (guess != mnumber)
        {
        if (guess > mnumber)
        {
        Console.WriteLine($"Higher");
        }
        else if (guess < mnumber)
        {
            Console.WriteLine($"Lower");            
        }

        Console.Write("What is your guess? ");
        string number3 = Console.ReadLine();
        guess = int.Parse (number3);
        x=x+1;
        }

        Console.WriteLine($"You guessed it! You have {x} guessess");
    }
}