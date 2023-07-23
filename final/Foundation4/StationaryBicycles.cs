class StationaryBicycles : Activity
{
    private double _speed;
    private double _distance;

    public StationaryBicycles(DateTime date, int length, double speed)
        : base(date, length)
    {
        _speed = speed;
        _distance = _speed * _length / 60; // Calculate distance based on speed and time (minutes)
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return 60 / _speed; // Minutes per mile
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Stationary Bicycles ({_length} min) - Speed: {_speed:F1} mph, Distance: {_distance:F2} miles, Pace: {GetPace():F1} min per mile";
    }
}
