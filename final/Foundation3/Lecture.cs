class Lecture : Event
{
    private string _speakerName;
    private int _capacity;

    public Lecture(string speakerName, int capacity, string title, string description, DateTime date, TimeSpan time, Address address)
        : base("Lecture", title, description, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public void SetSpeakerName(string speakerName)
    {
        _speakerName = speakerName;
    }

    public string GetSpeakerName()
    {
        return _speakerName;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayStandDetails();
        Console.WriteLine($"Speaker: {_speakerName}, Capacity: {_capacity}");
    }
}