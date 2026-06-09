using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("red", 8));
        shapes.Add(new Rectangle("blue", 4, 8));
        shapes.Add(new Circle("yellow", 5));

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"{shape.GetColor()} - {shape.GetArea()} m2");
        }
    }
}