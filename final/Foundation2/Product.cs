class Product
{
    private string _name;
    private int _id;
    private decimal _price;
    private int _quantity;

    public Product(string name, int id, decimal price, int quantity)
    {
        _name = name;
        _id = id;
        _price = price;
        _quantity = quantity;
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public string GetName()
    {
        return _name;
    }

    public void SetId(int id)
    {
        _id = id;
    }

    public int GetId()
    {
        return _id;
    }

    public void SetPrice(decimal price)
    {
        _price = price;
    }
    public decimal GetPrice()
    {
        return _price;
    }

    public void SetQuantity(int quantity)
    {
        _quantity = quantity;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
}
