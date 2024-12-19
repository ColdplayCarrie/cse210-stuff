using System;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
    }

        public override double GetDistance()
    {
        double distance = _laps * 50 * 0.62 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = GetDistance() / _length * 60;
        return speed;
    }

    public override int GetPace()
    {
        var speed = GetSpeed();
        double pace = 60 / speed;
        var returnValue = (int)Math.Round(pace);
        return returnValue;
    }

    public override string GetSummary()
    {
        return $"{_date}, Swimming ({_length} min)--> Distance: {GetDistance()} miles, Speed: {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}