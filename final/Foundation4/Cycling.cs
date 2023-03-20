public class Cycling : Activity
{
    protected double _Speed;
    public Cycling() : base ()
    {
        Console.Write("Speed (kph): ");
        _Speed = double.Parse(Console.ReadLine());
    }
    public override double Speed ()
    {
        return _Speed;
    }
    public override double Pace ()
    {
        return 60/_Speed ;
    }
    public override string ActivityName ()
    {
        return "Cycling";
    }
    public override double Metric ()
    {
        return _Speed *_Time /60;
    }
}