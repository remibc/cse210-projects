using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine($"Standard Message");
        Standard S1 = new Standard();
        Console.WriteLine($"\nFull Detail Message");
        Full F1 = new Full();
        Console.WriteLine($"\nShort Description Message");
        Short SH = new Short();
    }
}