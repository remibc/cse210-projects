using System;

public class word{

    private int _word;

    public word(string [] s)
    {  
        Random randomGenerator = new Random();
        int mnumber = randomGenerator.Next(0,s.Length);
        if (s[mnumber] == "_____")
        {
            while (s[mnumber] == "_____")
            {
                randomGenerator = new Random();
                mnumber = randomGenerator.Next(0,s.Length);  
            }
        }
        _word = mnumber;
        //System.Console.WriteLine($"<{scripture[mnumber]}>");
        //foreach (var word in scripture)
        //{
        //    System.Console.WriteLine($"{word}");
        //}
    }

    public int selectWord()
    {
        int selectWord = _word;
        return selectWord;
    }

}