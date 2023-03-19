using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome!");
        string anw = Menu();
        List<Video> List = new List<Video>();

        while (anw!="5")
        {
            if (anw == "1")
            {
                Video o1 =new Video();
                List.Add(o1);
            }
            if (anw == "2")
            {
                Console.Clear();
                foreach (Video s in List)
                {
                    Console.WriteLine($"Video: {s.Title()}\nAuthor: {s.Author()}\nDuration: {s.Length()} sec\nComments: {s.Display().Length - 1 }");
                    foreach (string t in s.Display() )
                    {
                        Console.WriteLine($"\t{t}");
                    }
                }
                Console.ReadLine();
            }
            if (anw == "3")
            {
                Console.Clear();
                using (StreamWriter outputFile = new StreamWriter("videos.txt"))
                {
                    foreach (Video s in List)
                    {
                        outputFile.WriteLine($"{s.Title()},{s.Author()},{s.Length()},{s.Comment()}");
                    }
                }
                Console.WriteLine("Video.txt was saved successfully");
                Console.ReadLine();
            }
            if (anw == "4")
            {
                Console.Clear();
                string[] lines = System.IO.File.ReadAllLines("videos.txt");
                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");
                    Video o1 = new Video(parts[0],parts[1],int.Parse(parts[2]),parts[3]);
                    List.Add(o1);
                }
                Console.WriteLine("Video.txt was loaded successfully");
                Console.ReadLine();
            }
            anw = Menu();
        }

        static string Menu()
        {
            Console.Clear();
            Console.Write("Menu Options: \n\t1. Add New Video\n\t2. List Videos and Comments\n\t3. Save Videos\n\t4. Load Videos\n\t5. Quit\nOption: ");
            string choise = Console.ReadLine();
            return choise;
        }
    }
}