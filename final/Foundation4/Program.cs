using System;

class Program
{
    static void Main(string[] args)
    {
        string anw = Menu();
        List<Activity> List = new List<Activity>();
        while (anw != "5")
        {
            if (anw == "1")
            {
                Running o1 = new Running();
                List.Add(o1);
            }
            if (anw == "2")
            {
                Cycling o1 = new Cycling();
                List.Add(o1);
            }
            if (anw == "3")
            {
                Swimming o1 = new Swimming();
                List.Add(o1);
            }
            if (anw == "4")
            {
                foreach (Activity s in List)
                {
                    Console.Clear();
                    Console.WriteLine($"Summary:\n{s.GetDate()} {s.ActivityName()} ({s.GetTime()} min) - Distance {s.Metric().ToString("0.00")} km, Speed {s.Speed().ToString("0.00")} kph, Pace {s.Pace().ToString("0.00")} min per km");
                    Console.ReadLine();
                }
            }

            anw = Menu();
        }
        static string Menu()
        {
            Console.Clear();
            Console.Write("Sport: \n\t1. Runnning\n\t2. Cycling\n\t3. Swimming\n\t4. Get Summary\n\t5. Quit\nOption: ");
            string choise = Console.ReadLine();
            return choise;
        }
    }
}