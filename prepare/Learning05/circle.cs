
using System;

public class Circle : Shape

{
    private double _radius;

    public Circle(double radius, string color) : base(color)
    {
        _radius = radius;
        _color = color;
    }

    public double GetSquare()
    {
        return _radius;
    }

    public void SetTitle(double radius)
    {
        _radius = radius;
    }

    public override double GetArea(){
        return _radius*_radius*(Math.PI);
    }

}