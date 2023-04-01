using System;

class Program
{
    static void Main(string[] args)
    {       
        Console.WriteLine("Order 1");
        Order o1 = new Order();
        o1.Shipping();
        Console.WriteLine("");
        o1.Packing1();
        Console.WriteLine("");
        Console.WriteLine($"TOTAL.....${o1.Total().ToString("0.00")}");

        Console.WriteLine("\nOrder 2");
        o1.Shipping();
        Console.WriteLine("");
        o1.Packing2();
        Console.WriteLine("");
        Console.WriteLine($"TOTAL.....${o1.Total().ToString("0.00")}");
    }
}