using System;
using System.IO;

public class SimpleGoal : Base
{
    public SimpleGoal()
    {
        Simple();
    }
    public SimpleGoal(string GoalName, string GoalDescription, String GoalPoint, bool GoalStatus ) 
    {
        Complex(GoalName,GoalDescription,GoalPoint,GoalStatus);
    }
    public override string GetActivity()
    {
        return "SimpleGoal";
    }
}