using System;

public class Cycling : Activity
{
    private int _speed;

    public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        
        double distance = _length / 60.0 * _speed;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override int GetPace()
    {
        int pace = 60 / _speed;
        return pace;
    }

    public override string GetSummary()
    {
        return $"{_date}, Cycling ({_length} min)--> Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}