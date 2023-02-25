using System;

class Program
{
    static void Main(string[] args)
    {
        string anw = menu();

        valid(anw);

        while (anw != "4")
        {
            if (anw == "1")
            {
                BreathingActivity o1 = new BreathingActivity();
                Console.Write(o1);
            }
            else if (anw == "2")
            {
                ReflectionActivity o2 = new ReflectionActivity();
                Console.Write(o2);
            }
            else if (anw == "3")
            {
                ListingActivity o3 = new ListingActivity();
                Console.Write(o3);
            }

            anw = menu();

            valid(anw);
        }

        static string menu()
        {
            Console.Clear();
            Console.Write("Menu Options:\n\t1. Breathing Activity\n\t2. Reflecting Activity\n\t3. Listing Activity\n\t4. Quit\nOption: ");
            string choise = Console.ReadLine();
            return choise;
        }
            //New function to make the user to select the correct option
        static void valid(string anw)
        {
            if (anw !="1" && anw !="2" && anw !="3" && anw !="4" )
                {
                    Console.WriteLine("This option is not valid. Please select a valid option\n");
                    Thread.Sleep(3000);
                }
        }
    }
}