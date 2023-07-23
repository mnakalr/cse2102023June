class Reception : Event
{
    private string _RSVPemail;

    public Reception(string RSVPemail, string title, string description, DateTime date, TimeSpan time, Address address)
        : base("Reception", title, description, date, time, address)
    {
        _RSVPemail = RSVPemail;
    }

    public void SetRSVPemail(string RSVPemail)
    {
        _RSVPemail = RSVPemail;
    }

    public string GetRSVPemail()
    {
        return _RSVPemail;
    }

    public override void DisplayFullDetails()
    {
        base.DisplayStandDetails();
        Console.WriteLine($"RSVP Email: {_RSVPemail}");
    }
}