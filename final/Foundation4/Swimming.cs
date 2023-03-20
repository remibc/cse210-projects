public class Swimming : Activity
{
    protected double _Laps;
    public Swimming() : base ()
    {
        Console.Write("Laps: ");
        _Laps = int.Parse(Console.ReadLine());
    }
    public override double Speed ()
    {
        return Metric()/_Time * 60;
    }
    public override double Pace ()
    {
        return _Time/Metric();
    }
    public override string ActivityName ()
    {
        return "Swimming";
    }
    public override double Metric ()
    {
        return _Laps * 50 / 1000;
    }
}