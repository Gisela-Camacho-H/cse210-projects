
public class Square : Shape

{
    private double _side;

    public Square(double side, string color) : base(color)
    {
        _side = side;
        _color = color;
    }

    public double GetSquare()
    {
        return _side;
    }

    public void SetSquare(double side)
    {
        _side = side;
    }

    public override double GetArea(){
        return _side*_side;
    }

}