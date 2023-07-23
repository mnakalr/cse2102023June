class Event
{
    protected string _eventType;
    protected string _title;
    protected string _description;
    protected DateTime _date;
    protected TimeSpan _time;
    protected Address _address;

    public Event(string eventType, string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _eventType = eventType;
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public void SetEventType(string eventType)
    {
        _eventType = eventType;
    }

    public string GetEventType()
    {
        return _eventType;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetTitle()
    {
        return _title;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDate(DateTime date)
    {
        _date = date;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void SetTime(TimeSpan time)
    {
        _time = time;
    }

    public TimeSpan GetTime()
    {
        return _time;
    }

    public void SetAddress(Address address)
    {
        _address = address;
    }

    public Address GetAddress()
    {
        return _address;
    }

    public void DisplayStandDetails()
    {
        Console.WriteLine($"Standard Details:");
        Console.WriteLine($"{_date}: Duration ({_time}) - {_title}: {_description}");
        Console.WriteLine($"{_address}");
    }

    public virtual void DisplayFullDetails()
    {
        DisplayStandDetails();
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"{_date} {_eventType} - {_title}");
    }
}
