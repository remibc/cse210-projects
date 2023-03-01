using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square test1 = new Square("Red", 3);
        //Console.WriteLine(test1.GetArea());
        shapes.Add(test1);

        Rectangle test2 = new Rectangle("Blue", 4, 5);
        //Console.WriteLine(test2.GetArea());
        shapes.Add(test2);

        Circle test3 = new Circle("Green", 6);
        //Console.WriteLine(test3.GetArea());
        shapes.Add(test3);

        foreach (Shape s in shapes)
        {
            Console.WriteLine($"The {s.GetColor()} shape has an area of {s.GetArea()}.");
        }

    }
}