public class Square : Shape
{

    public Square(string color, double side) : base(color)
    {
        _side = side;
    }
    private double _side;

    public override double getArea()
    {
        return _side * _side;
    }

}
