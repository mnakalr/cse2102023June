class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int length, double distance)
        : base(date, length)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _distance / _length * 60; // Miles per hour
    }

    public override double GetPace()
    {
        return _length / _distance; // Minutes per mile
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Running ({_length} min) - Distance: {_distance:F2} miles, Speed: {GetSpeed():F1} mph, Pace: {GetPace():F1} min per mile";
    }
}
