using System;

class Program
{
    static void Main(string[] args)
    {
        string letter ="";
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percentage = int.Parse (answer);

        if (percentage>=90)
        {
            letter ="A";
        }
        else if (percentage>=80)
        {
            letter ="B";
        }
        else if (percentage>=70)
        {
            letter ="C";
        }
        else if (percentage>=60)
        {
            letter ="D";
        }
        else if (percentage<60)
        {
            letter ="F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed!");
        }
        else
        {
            Console.WriteLine("Please study you can do it!!");
        }
    }
}