class Customer
{
    private string _name;
    private int _id;
    private List<Address> _addresses;
    private string _email;
    private bool _IsCustomerInUSA;

    public Customer(string name, int id, Address address, string email)
    {
        _name = name;
        _id = id;
        _addresses = new List<Address>();
        _addresses.Add(address);
        _email = email;
        _IsCustomerInUSA = _addresses.Count > 0 && _addresses[0].GetCountry().Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void AddAddress(Address address)
    {
        _addresses.Add(address);
    }
    public List<Address> GetAddresses()
    {
        return _addresses;
    }

    public void SetEmail(string email)
    {
        _email = email;
    }
    public string GetEmail()
    {
        return _email;
    }

    public bool IsCustomerInUSA()
    {
        return _IsCustomerInUSA;
    }


}
