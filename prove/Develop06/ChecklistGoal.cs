using System;
using System.Runtime;

public class ChecklistGoal : Goal
{
    private int _amountCompleted = 0;
    private int _target = 0;
    private int _bonus = 0;
    private bool _isComplete = false;

    public ChecklistGoal(string name, string description, int points, int bonus, int target, int amountCompleted) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        if (_isComplete)
        {
            return 0;
        }

        _amountCompleted++;

        if (_amountCompleted == _target)
        {
            _isComplete = true;
            return _points + _bonus;
        }

        return _points;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        if(IsComplete())
        {
            return "[X] " + _shortName + " (" + _description + ") -- Currently completed: " + _amountCompleted + "/" + _target;
        }
        else
        {
            return "[ ] " + _shortName + " (" + _description + ") -- Currently completed: " + _amountCompleted + "/" + _target;
        }
    }

    public override string GetStringRepresentation()
    {
        return "ChecklistGoal:" + _shortName + "," + _description + "," + _points + "," + _bonus + "," + _target + "," + _amountCompleted;
    }
}