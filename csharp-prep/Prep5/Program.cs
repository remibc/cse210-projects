using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string username = PromptUserName();
        int usernumber = PromptUserNumber();
        int square = SquareNumber(usernumber);

        DisplayResult(username,square);

        static void DisplayWelcome ()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName ()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int snumber)
        {
            int square = snumber * snumber;
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}