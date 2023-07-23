class OutdoorGathering : Event
{
    private string _weather;

    public OutdoorGathering(string weather, string title, string description, DateTime date, TimeSpan time, Address address)
        : base("Outdoor Gathering", title, description, date, time, address)
    {
        _weather = weather;
    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }

    public string GetWeather()
    {
        return _weather;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayStandDetails();
        Console.WriteLine($"Weather: {_weather}");
    }
}
