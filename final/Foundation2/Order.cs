class Order
{
    private int _id;
    private List<Product> _products;
    private Customer _customer;
    private DateTime _date;

    public Order(int id, List<Product> products, Customer customer, DateTime date)
    {
        _id = id;
        _products = products;
        _customer = customer;
        _date = date;
    }

    public int GetId()
    {
        return _id;
    }

    public List<Product> GetProducts()
    {
        return _products;
    }

    public Customer GetCustomer()
    {
        return _customer;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void DisplayOrder()
    {
        Console.WriteLine($"Order ID: {_id}");
        Console.WriteLine($"Order Date: {_date}");
        Console.WriteLine($"Customer: {_customer.GetName()}");
        Console.WriteLine($"Customer Email: {_customer.GetEmail()}");
        Console.WriteLine("Products:");
        foreach (Product product in _products)
        {
            Console.WriteLine($" - {product.GetName()}, Price: {product.GetPrice()}, Quantity: {product.GetQuantity()}");
        }
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (Product product in _products)
        {
            total += product.GetPrice() * product.GetQuantity();
        }

        // Add shipping cost based on the customer's country
        if (_customer.IsCustomerInUSA())
        {
            total += 5; // USA shipping cost: $5
        }
        else
        {
            total += 35; // International shipping cost: $35
        }

        return total;
    }


    public string PackLabel()
    {
        string packing = $"Packing Label for Order ID {_id}\n";
        foreach (Product product in _products)
        {
            packing += $"Product: {product.GetName()}, ID: {product.GetId()}\n";
        }
        return packing;
    }

    public string ShippingLabel()
    {
        string shipping = $"Shipping Label for Order ID {_id}\n";
        shipping += $"Customer Name: {_customer.GetName()}\n";
        if (_customer.GetAddresses().Count > 0)
        {
            Address address = _customer.GetAddresses()[0];
            shipping += "Customer Address: ";
            shipping += $"{address.GetStreet()}, {address.GetCity()}, {address.GetState()} {address.GetCountry()}\n";
        }
        return shipping;
    }
}
