using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square mySquare = new Square(20, "blue");
        shapes.Add(mySquare);

        Rectangle myRectangle = new Rectangle(20, 10, "black");
        shapes.Add(myRectangle);

        Circle myCircle = new Circle(3, "red");
        shapes.Add(myCircle);

        foreach (Shape shape in shapes){
            string color = shape.GetColor();

            double area = shape.GetArea();

            Console.WriteLine($"the {color} shape has an area of {area}.");
        }
    }
}