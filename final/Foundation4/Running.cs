public class Running : Activity
{
    protected double _Distance;
    public Running() : base ()
    {
        Console.Write("Distance (km): ");
        _Distance = double.Parse(Console.ReadLine());
    }
    public override double Speed ()
    {
        return _Distance /_Time * 60;
    }
    public override double Pace ()
    {
        return _Time/_Distance ;
    }
    public override string ActivityName ()
    {
        return "Running";
    }
    public override double Metric ()
    {
        return _Distance;
    }
}