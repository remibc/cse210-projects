using System;
using System.IO;

public class CheckingGoal : Base
{
    public CheckingGoal()
    {
        Simple();
        Extra();
    }
    public CheckingGoal(string GoalName, string GoalDescription, String GoalPoint, string GoalTime, string GoalBonus, bool GoalStatus, int GoalCounts)
    {
        ComplexExtra(GoalName,GoalDescription,GoalPoint,GoalTime,GoalBonus,GoalStatus,GoalCounts);
        
    }
    public override string GetActivity()
    {
        return "CheckingGoal";
    }
}