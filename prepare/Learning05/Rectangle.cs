public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public void SetLength(double length)
    {
        _length = length;
    }

    public double GetLength()
    {
        return _length;
    }

    public void SetWidth(double width)
    {
        _width = width;
    }

    public double GetWidth()
    {
        return _width;
    }

    public override double GetArea()
    {
        // Calculate and return the area of the rectangle
        return _width * _length;
    }
}

