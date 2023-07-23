class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int length, int laps)
        : base(date, length)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return _laps * 50 / 1000; // Kilometers
    }

    public override double GetSpeed()
    {
        return GetDistance() / _length * 60; // Kilometers per hour
    }

    public override double GetPace()
    {
        return _length / GetDistance(); // Minutes per kilometer
    }

    public override string GetSummary()
    {
        return $"{_date.ToShortDateString()} Swimming ({_length} min) - Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }
}
