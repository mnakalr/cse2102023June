class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    public void SetStreet(string street)
    {
        _street = street;
    }
    public string GetStreet()
    {
        return _street;
    }

    public void SetCity(string city)
    {
        _city = city;
    }
    public string GetCity()
    {
        return _city;
    }

    public void SetState(string state)
    {
        _state = state;
    }
    public string GetState()
    {
        return _state;
    }

    public void SetCountry(string country)
    {
        _country = country;
    }
    public string GetCountry()
    {
        return _country;
    }

    public void DisplayFullAddress()
    {
        Console.Write($"{_street}, {_city}, {_state} {_country}");
    }
}
