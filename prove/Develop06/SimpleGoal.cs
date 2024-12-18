using System;
using System.ComponentModel;

public class SimpleGoal: Goal
{
    private bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, bool complete) : base(name, description, points) 
    {
        _isComplete = complete;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _isComplete = true;

        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }   

    public override string GetStringRepresentation()
    {
        return "SimpleGoal:" + _shortName + "," + _description + "," + _points + "," + _isComplete;
    } 
}