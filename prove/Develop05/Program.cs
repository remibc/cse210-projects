using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        Console.WriteLine($"\nYour score is {sum} points\n");
        string anw = Menu();
        valid(char.Parse(anw),6);
        List<Base> List = new List<Base>();

        while (anw != "6")
        {
            if (anw == "1")
            {
                string aanw = Activity();
                valid(char.Parse(aanw),3);
                if (aanw=="1")
                {
                    SimpleGoal Test1 = new SimpleGoal();
                    List.Add(Test1);
                }
                else if (aanw =="2")
                {
                    EternalGoal Test1 = new EternalGoal();
                    List.Add(Test1);
                }
                else if (aanw =="3")
                {
                    CheckingGoal Test1 = new CheckingGoal();
                    List.Add(Test1);
                }
            }
            else if (anw == "2")
            {
                Console.WriteLine("The Goals are: ");
                int x = 1;
                foreach (Base s in List)
                {
                    if (s.GetActivity()=="EternalGoal" || s.GetActivity()=="SimpleGoal" )
                    {
                        if (s.GetStatus())
                        {
                            Console.WriteLine($"{x}. [X] {s.GetName()} ({s.GetDesc()})");
                        }
                        else
                        {
                            Console.WriteLine($"{x}. [ ] {s.GetName()} ({s.GetDesc()})");
                        }
                        
                        x= x+1;
                    }
                    else
                    {
                        if (s.GetStatus())
                        {
                            Console.WriteLine($"{x}. [X] {s.GetName()} ({s.GetDesc()}) -- Currently completed: {s.GetCounts()}/{s.GetTime()}");
                        }
                        else
                        {
                            Console.WriteLine($"{x}. [ ] {s.GetName()} ({s.GetDesc()}) -- Currently completed: {s.GetCounts()}/{s.GetTime()}");
                        }
                        x= x+1;
                    }
                }
            }
            else if (anw == "3")
            {
                //Give the user the oportunity to save the docuemnt in a CSV or TXT
                Console.Write("\nWould you like to save your document in a CSV File? (Y/N) ");
                string ynSave = Console.ReadLine();

                if (ynSave.ToUpper() == "Y")
                {
                    Console.Write("Name for CSV: ");
                    string newName = Console.ReadLine();
                    newName = newName + ".csv";
                    save(sum,newName,List);
                    Console.Write($"\nList was saved succesfully in {newName}!\n");
                }
                else
                {
                    Console.Write("Name for TXT: ");
                    string newName = Console.ReadLine();
                    newName = newName + ".txt";
                    save(sum,newName,List);
                    Console.Write($"\nList was saved succesfully in {newName}!\n"); 
                }
            }
            else if (anw == "4")
            {
                Console.Write("CSV or TXT file?  ");
                string fileType = Console.ReadLine();
                Console.Write("Name of the file: ");
                string fileName = Console.ReadLine();
                
                if (fileType.ToUpper() == "CSV")
                {
                    fileName = fileName + ".csv"; //User  doesn't have to write the file type
                    sum = load(fileName,List);
                }
                else if (fileType.ToUpper() == "TXT")
                {
                    fileName = fileName + ".txt";
                    sum = load(fileName,List);
                }
                else if (fileType.ToUpper() != "TXT" && fileType.ToUpper() != "CSV"  )
                {
                    Console.WriteLine("The document type is not valid");
                }
            }
            else if (anw == "5")
            {
                Console.WriteLine("The Goals are: ");
                int x = 1;
                foreach (Base s in List)
                {
                    Console.WriteLine($"{x}. {s.GetName()}");
                    x = x+1;
                }

                Console.Write("Wich goal did you accomplish? ");
                int choise = int.Parse(Console.ReadLine());
                if (List[choise-1].GetActivity() == "SimpleGoal" && List[choise-1].GetStatus() == false) //If the goal is already completed. The points are not valid
                {
                    sum = sum + int.Parse(List[choise-1].GetPoint());
                    List[choise-1].ChangeStatus();
                    Console.WriteLine($"Congratulation you win {List[choise-1].GetPoint()} points");
                }
                else if (List[choise-1].GetActivity() == "CheckingGoal"  && List[choise-1].GetStatus() == false)
                {
                    List[choise-1].SumPoints();
                    if (int.Parse(List[choise-1].GetTime()) >= List[choise-1].GetCounts())
                    {
                        sum = sum + int.Parse(List[choise-1].GetPoint());
                        Console.WriteLine($"Congratulation you win {List[choise-1].GetPoint()} points");
                    }
                    if (int.Parse(List[choise-1].GetTime()) == List[choise-1].GetCounts())
                    {
                        sum = sum + int.Parse(List[choise-1].GetBonus());
                        List[choise-1].ChangeStatus();
                    }
                }
                else if (List[choise-1].GetActivity() == "EternalGoal")
                {
                    sum = sum + int.Parse(List[choise-1].GetPoint());
                    Console.WriteLine($"Congratulation you win {List[choise-1].GetPoint()} points");
                }
                else
                {
                    Console.WriteLine("This Goal is already completed.");
                }
                
            }
            Console.WriteLine($"\nYour score is {sum} points\n");
            anw = Menu();
            valid(char.Parse(anw),6);
        }

        static string Menu()
        {
            Console.Write("Menu Options: \n\t1. Create a new goal\n\t2. List Goals\n\t3. Save Goals\n\t4. Load Goals\n\t5. Record Event\n\t6. Quit\nOption: ");
            string choise = Console.ReadLine();
            return choise;
        }
        static string Activity()
        {
            Console.Write("The types of Goals are; \n\t1. Simple Goal\n\t2. Eternal Goal\n\t3. Checking Goal\nWhich type of goal would you like to create?  ");
            string choise = Console.ReadLine();
            return choise;
        }
        //New function to make the user to select the correct option
        static void valid(char anw,int Options)
        {
            if (Char.GetNumericValue(anw) > Options || char.IsDigit(anw)== false)
                {
                    Console.WriteLine("This option is not valid. Please select a valid option\n");
                    Thread.Sleep(3000);
                }
        }

        static void save(int sum,string name, List<Base> List)
        {
            using (StreamWriter outputFile = new StreamWriter(name))
            {
                outputFile.WriteLine(sum);
                foreach (Base print in List)
                {
                    if (print.GetActivity()=="CheckingGoal")
                    {
                        outputFile.WriteLine($"{print.GetActivity()}:{print.GetName()},{print.GetDesc()},{print.GetPoint()},{print.GetTime()},{print.GetBonus()},{print.GetStatus()},{print.GetCounts()}");
                    }
                    else
                    {
                        outputFile.WriteLine($"{print.GetActivity()}:{print.GetName()},{print.GetDesc()},{print.GetPoint()},{print.GetStatus()}");
                    }                    
                }
            }
        }
        static int load(string name, List<Base> List)
        {
            string[] lines = System.IO.File.ReadAllLines(name);
            int sum = int.Parse(lines[0]);
            foreach (string line in lines)
            {
                string[] parts = line.Split(",");
                string[] activity = parts[0].Split(":");
                if (activity[0] == "CheckingGoal")
                {
                    CheckingGoal Test1 = new CheckingGoal(activity[1],parts[1],parts[2],parts[3],parts[4],bool.Parse(parts[5]),int.Parse(parts[6]));
                    List.Add(Test1);
                }
                else if (activity[0] == "SimpleGoal")
                {
                    SimpleGoal Test1 = new SimpleGoal(activity[1],parts[1],parts[2],bool.Parse(parts[3]));
                    List.Add(Test1);
                }
                else if (activity[0] == "EternalGoal")
                {
                    EternalGoal Test1 = new EternalGoal(activity[1],parts[1],parts[2],bool.Parse(parts[3]));
                    List.Add(Test1);
                }
            }
            return sum;
        }       
    }
}