class Address
{
    private string _houseNumber;
    private string _street;
    private string _city;
    private string _region;
    private string _country;

    public Address(string houseNumber, string street, string city, string region, string country)
    {
        _houseNumber = houseNumber;
        _street = street;
        _city = city;
        _region = region;
        _country = country;
    }

    public void SetHouseNumber(string houseNumber)
    {
        _houseNumber = houseNumber;
    }

    public string GetHouseNumber()
    {
        return _houseNumber;
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

    public void SetRegion(string region)
    {
        _region = region;
    }

    public string GetRegion()
    {
        return _region;
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
        Console.Write($"{_houseNumber} {_street}, {_city}, {_region} {_country}");
    }
}