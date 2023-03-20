public abstract class Activity
{
    private string _Date;
    protected double _Time;
    public Activity()
    {
        Console.Clear();
        Console.WriteLine($"***{ActivityName()}***");
        Console.Write("Select the Date: ");
        _Date = Console.ReadLine();
        Console.Write("Time (min): ");
        _Time = int.Parse(Console.ReadLine());
    }
    public string GetDate()
    {
        return _Date;
    }
    public double GetTime()
    {
        return _Time;
    }
    public abstract double Speed();
    public abstract double Pace();
    public abstract string ActivityName();
    public abstract double Metric();
    
}