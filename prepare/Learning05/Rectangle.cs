public class Rectangle: Shape
{


    private double _side_1;
    private double _side_2;
    public Rectangle(string color, double side_1, double side_2) : base(color)
    {
        _side_1 = side_1;
        _side_2 = side_2;
    }

    public override double getArea()
    {
        return _side_1 * _side_2;
    }

}
