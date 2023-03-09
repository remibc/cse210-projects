using System;
using System.IO;

public class EternalGoal : Base
{
    public EternalGoal()
    {
        Simple();
    }
    public EternalGoal(string GoalName, string GoalDescription, String GoalPoint, bool GoalStatus) 
    {
        Complex(GoalName,GoalDescription,GoalPoint,GoalStatus);
    }
    public override string GetActivity()
    {
        return "EternalGoal";
    }
}