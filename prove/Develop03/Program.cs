using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Exceed requirement program will ask if user wants to get the scripture from a TXT file or generic scripture
        //in the TXT file please split the book,chapter and verse, verse info by "|", 
        Console.WriteLine("Do you want to use the Scripture from the TXT file ? (Y/N)");
        string ynSave = Console.ReadLine();

        if (ynSave.ToUpper() == "N")
        {
            reference s = new reference();
            Console.Clear();
            Console.WriteLine(s.print());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string answer = Console.ReadLine();
        
            scripture r = new scripture();
            while (answer.ToUpper() != "QUIT")
            {
                Console.Clear();
                s = new reference(r.print());
                Console.Write(s.print());

                string[] scripture = r.print().Split(' ');
                int intento = 0;
                foreach (var sentence in scripture)
                {
                    if (sentence == "_____")
                    {
                        intento = intento + 1 ;
                    }
                }
                if (intento == scripture.Length)
                {
                    answer = "quit";
                    Console.WriteLine("\n\nThere are no more letter to hide");
                }
                else{
                    Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish: ");
                    answer = Console.ReadLine();
                    r = new scripture(r.print());
                }
            }
        }
        else if (ynSave.ToUpper() == "Y")
        {
            string[] lines = System.IO.File.ReadAllLines("text.txt");
            string[] parts = lines[0].Split("|");

            reference s = new reference(parts[0],parts[1],parts[2],parts[3]);
            
            Console.Clear();
            Console.WriteLine(s.print());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish: ");
            string answer = Console.ReadLine();
        
            scripture r = new scripture(parts[0],parts[1],parts[2],parts[3]);
            while (answer != "quit")
            {
                Console.Clear();
                s = new reference(parts[0],parts[1],parts[2],r.print());
                Console.Write(s.print());

                string[] scripture = r.print().Split(' ');
                int intento = 0;
                foreach (var sentence in scripture)
                {
                    if (sentence == "_____")
                    {
                        intento = intento + 1 ;
                    }
                }
                if (intento == scripture.Length)
                {
                    answer = "quit";
                    Console.WriteLine("\n\nThere are no more letter to hide");
                }
                else{
                    Console.WriteLine("\n\nPress enter to continue or type 'quit' to finish: ");
                    answer = Console.ReadLine();
                    r = new scripture(r.print());
                }
            }
        }
        //if another option is selected program will break
        else if (ynSave.ToUpper() != "Y" && ynSave.ToUpper() != "N")
        {
            Console.WriteLine("\nThis is not a valid option. Please run again the program! ");
    
        }
    }
}