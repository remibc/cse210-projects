using System;
using System.IO;

public class ListingActivity : activity{
    private string _question;
    private List<string> _list = new List<string>();
    public ListingActivity()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Listing Activity.\n");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");
        int seconds = second();
        Console.Clear();

        GetReady(); 

        Random randomGenerator = new Random();
        int mnumber = randomGenerator.Next(1,4);

        switch (mnumber)
        {
            case 1:
                _question = "Who are people that you appreciate?";
            break;
            case 2:
                _question = "What are personal strengths of yours?.";
            break;
            case 3:
                _question = "Who are people that you have helped this week?";
            break;
            case 4:
                _question = "When have you felt the Holy Ghost this month?";
            break;
            case 5:
                _question = "Who are some of your personal heroes?";
            break;
        }

        Console.WriteLine($"\nList as many responses you can to the following: \n\n\t****** {_question} ******");
        
        Console.Write($"You may begin in: ");
        numbers();

        Console.WriteLine("");
        int x = 0;

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);
        while (startTime < futureTime)
        {
            Console.Write(">");
            string list = Console.ReadLine();
            startTime = DateTime.Now;
            x=x+1;
            _list.Add(list);
        }
        Console.WriteLine($"You listed {x} items!");

        //List will be saved in TXT File if user wants to do it. if not nothing happen.If user enter an invalid option will ask until answer will be N


        Console.WriteLine("Would you like to save your file in MyFile.TXT? (Y/N)");
        string YN = Console.ReadLine();

        while ( YN.ToUpper() != "N")
        {

        if (YN.ToUpper() == "Y")
        {
            using (StreamWriter outputFile = new StreamWriter("MyList.txt"))
            {
                foreach (string print in _list)
                {
                    outputFile.WriteLine(print);
                }
            }
            Console.WriteLine("Saving");
            clock();
            Console.Write("\nList was saved succesfully in MyList.TXT!\n");
            YN ="N";
        }
        else if (YN.ToUpper() != "Y" && YN.ToUpper() != "N" )
        {
            Console.WriteLine("Invalid option.\n");                    
            Console.WriteLine("Would you like to save your file in MyFile.TXT? (Y/N)");
            YN = Console.ReadLine();
        }
        }

        WellDone(seconds, "Listining Activity");
    }

}