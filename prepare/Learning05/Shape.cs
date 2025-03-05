public class Shape {
    protected string _color;


    public Shape(string color) {
        _color = color;
    }

   public string getColor() {
        return _color;
    }

    public void setColor(string color) {
        _color = color;
    }

    virtual public double getArea(){
        return 0;
    }
}