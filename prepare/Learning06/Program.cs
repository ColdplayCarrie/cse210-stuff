using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square square1 = new Square("red", 4);
        shapes.Add(square1);
        Console.WriteLine(square1.GetColor() + ", " + square1.GetArea());

        Rectangle rectangle1 = new Rectangle("blue", 5, 10);
        shapes.Add(rectangle1);
        Console.WriteLine(rectangle1.GetColor() + ", " + rectangle1.GetArea());

        Circle circle1 = new Circle("pink", 11);
        shapes.Add(circle1);
        Console.WriteLine(circle1.GetColor() + ", " + circle1.GetArea());

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}