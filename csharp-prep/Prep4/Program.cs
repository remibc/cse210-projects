using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        int x=1;
        List<int> number = new List<int>();

        while (x != 0)
        {
            Console.Write("Enter a number ");
            string number2 = Console.ReadLine();
            x = int.Parse (number2);

            number.Add(x);

        }

        int sum = 0;
        int largest = 0;

        foreach (int word in number)
        {
            sum += word;
            if (word > largest)
            {
                largest = word;
            }
        }

        float average = ((float)sum) / (number.Count-1);

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The sum is: {largest}");

        number.Sort();
        foreach (int word in number)
        {
            Console.WriteLine(word);
        }
    }
}