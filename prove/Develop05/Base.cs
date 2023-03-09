public abstract class Base
{
    private string _GoalName;
    private string _GoalDescription ;
    private string _GoalTime;
    private string _GoalBonus ;
    private string _GoalPoint;
    protected bool _GoalStatus;
    private int _GoalCounts;
    public void Simple()
    {
        Console.Write("What it the name of your goal? ");
        _GoalName = Console.ReadLine();
        Console.Write("What is a Short Description of it? ");
        _GoalDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        _GoalPoint = Console.ReadLine();
        _GoalStatus = false;
    }
    public void Extra()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus?  ");
        _GoalTime = Console.ReadLine();
        Console.Write("What is the bonus for accomplishing it that many times?  ");
        _GoalBonus = Console.ReadLine();
        _GoalCounts = 0;
    }

    public void Complex(string GoalName, string GoalDescription, String GoalPoint, bool GoalStatus )
    {
        _GoalName = GoalName;
        _GoalDescription = GoalDescription;
        _GoalPoint = GoalPoint;
        _GoalStatus = GoalStatus;
    }
    public void ComplexExtra(string GoalName, string GoalDescription, String GoalPoint, string GoalTime, string GoalBonus, bool GoalStatus,int GoalCounts)
    {
        Complex(GoalName,GoalDescription,GoalPoint,GoalStatus);
        _GoalTime = GoalTime;
        _GoalBonus = GoalBonus;
        _GoalCounts = GoalCounts;
    }

    public string GetTime()
    {
        return _GoalTime;
    }
    public int GetCounts()
    {
        return _GoalCounts;
    }
    public void SumPoints()
    {
        _GoalCounts = _GoalCounts + 1;
    }
    public bool GetStatus()
    {
        return _GoalStatus;
    }
    public void ChangeStatus()
    {
        _GoalStatus = true;
    }
    public string GetBonus()
    {
        return _GoalBonus;
    }
    public  string GetName()
    {
        return _GoalName;
    }
    public  string GetDesc()
    {
        return _GoalDescription;
    }
    public  string GetPoint()
    {
        return _GoalPoint;
    }
    public abstract string GetActivity();

    
}
