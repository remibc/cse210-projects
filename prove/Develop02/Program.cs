using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please select one of the following options:\n\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nOption: ");
        string choise = Console.ReadLine();
        int anw = int.Parse (choise);

        Entry archive = new Entry();
        
        while (anw != 5)
        {
            if (anw==1)
            {
                Prompt nquestion = new Prompt();
                
                Random randomGenerator = new Random();
                int mnumber = randomGenerator.Next(1,5);

                nquestion.questions(mnumber);
    
                nquestion._answers = Console.ReadLine();

                DateTime theCurrentTime = DateTime.Now;
                nquestion._dateText = theCurrentTime.ToShortDateString();
                //I save also the date in the TXT file
                
                archive._number.Add(nquestion);
            }
            else if (anw == 2)
            {
                archive.display();
            }

            else if (anw == 3)
            {
                //Users have the option to load a TXT or CSV file .I added this conditions and the programs works for boths types of documents
                Console.Write("CSV or TXT file?  ");
                string fileType = Console.ReadLine();
                Console.Write("Name of the file: ");
                string fileName = Console.ReadLine();

                if (fileType.ToUpper() == "CSV")
                {
                    fileName = fileName + ".csv";
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                    string[] parts = line.Split(",");

                    Prompt nquestion = new Prompt();

                    nquestion._question = parts[0];
                    nquestion._answers = parts[1];
                    nquestion._dateText = parts[2];

                   
                    archive._number.Add(nquestion);
                    }
                Console.Write($"\n{fileName} was loaded succesfully\n");

                }
                else if (fileType.ToUpper() == "TXT")
                {
                    fileName = fileName + ".txt";
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                    string[] parts = line.Split(",");

                    Prompt nquestion = new Prompt();

                    nquestion._question = parts[0];
                    nquestion._answers = parts[1];
                    nquestion._dateText = parts[2];

                   
                    archive._number.Add(nquestion);
                    }
                Console.Write($"\n{fileName} was loaded succesfully\n");
                }
                else if (fileType.ToUpper() != "TXT" && fileType.ToUpper() != "CSV"  )
                {
                    Console.Write("The document type is not valid");
                }
                
            }

            else if (anw == 4)
            {
                //User will have the oprotunity to create a new document. if not it will save in the default document
                Console.Write("\nWould you like to save your docuemnt in a new CSV File? (Y/N) ");
                string ynSave = Console.ReadLine();

                

                if (ynSave.ToUpper() == "Y") //Change the answer in Uppercase. So it doesn't matter if the user dosen'r enter caps 
                {
                    Console.Write("New Name: ");
                    string newName = Console.ReadLine();
                    newName = newName + ".csv";
                    archive.save(newName);
                    Console.Write($"\nList was saved succesfully in {newName}!\n");                    
                }

                else if (ynSave.ToUpper() == "N" ) //Change the answer in Uppercase. So it doesn't matter if the user dosen'r enter caps 
                {
                    archive.save("myFile.csv");
                    Console.Write("\nList was saved succesfully in myFile.csv!\n");
                }

                else if (ynSave.ToUpper() != "N" && ynSave.ToUpper() != "Y" )
                {
                    //If user eneter an invalid answer the code will reject the value
                    Console.Write("\nThis is not a valid option. Please select a valid option\n");
                }
            }

            else if (anw > 5)
            {
                // I include this consition if the user enter an option that is not in the menu
                Console.Write ("\nThis is not a valid option. Please select a valid option\n");
            }

            Console.Write("\nPlease select one of the following options:\n\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit\n\nOption: ");
            choise = Console.ReadLine();
            anw = int.Parse (choise);
        }

    }
}