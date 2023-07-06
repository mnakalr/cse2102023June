
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        // Example usage
        Square square = new Square();
        square.SetSide(5);
        double squareArea = square.GetArea();
        Console.WriteLine($"Square area: {squareArea}");

        Rectangle rectangle = new Rectangle();
        rectangle.SetLength(4);
        rectangle.SetWidth(6);
        double rectangleArea = rectangle.GetArea();
        Console.WriteLine($"Rectangle area: {rectangleArea}");

        Circle circle = new Circle();
        circle.SetRadius(3);
        double circleArea = circle.GetArea();
        Console.WriteLine($"Circle area: {circleArea}");
    }
}
