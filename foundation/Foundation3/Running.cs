using System;

public class Running : Activity
{
    private int _distance;

    public Running(string date, int length, int distance) : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = 60 / GetPace();
        return speed;
    }

    public override int GetPace()
    {
        int pace = _length / _distance;
        return pace;
    }

    public override string GetSummary()
    {
        return $"{_date}, Running ({_length} min)--> Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}