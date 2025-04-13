using System;
class Program
{
    static void Main(string[] args)
    {
        // Create a list of shapes
        List<Shape> shapes = new List<Shape>();

        // Add a square
        Square s1 = new Square("Red", 3);
        shapes.Add(s1);

        // Add a rectangle
        Rectangle s2 = new Rectangle("Blue", 4, 5);
        shapes.Add(s2);

        // Add a circle
        Circle s3 = new Circle("Green", 6);
        shapes.Add(s3);

        // Iterate through the list and display color and area
        Console.WriteLine("Shapes in the list:");

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();
            double area = s.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area:F2}.");
        }
    }
}