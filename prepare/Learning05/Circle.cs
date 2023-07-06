public class Circle : Shape
{
    private double _radius;

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public double GetRadius()
    {
        return _radius;
    }

    public override double GetArea()
    {
        // Calculate and return the area of the circle
        return Math.PI * _radius * _radius;
    }
}
