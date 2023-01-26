using System;
using System.IO;

public class Entry{

    public List<Prompt> _number = new List<Prompt>();
    
        
    public void display(){
        foreach (Prompt print in _number)
        {
            Console.WriteLine($"\nDate: {print._dateText} - Prompt: {print._question}\n{print._answers}");
        }
    }

    public void save(string file){
        using (StreamWriter outputFile = new StreamWriter(file)){
            foreach (Prompt print in _number)
            {
                outputFile.WriteLine($"{print._question},{print._answers},{print._dateText}");
            }
        }
    }   
}