
class Fraction {
    private int _top;
    private int _bottom;

// Constructors 

public Fraction () {
    _top = 1;
    _bottom = 1;
}

public Fraction (int n) {
    _top = n;
    _bottom = 1;
}

public Fraction (int top, int b ) {
    _top = top;
    _bottom = b;
}

public string getFraction () {
    string text = $"{_top}/{_bottom}";
    return text;
}

public void setFraction(int t, int b){
    _top = t;
    _bottom = b;
}

public int getTop () {
    return _top;
}

public int getBottom () {
    return _bottom;
}

public void setTop (int t) {
    _top = t;
}


public void setBottom (int b) {
    _bottom = b;
}

public double getDecimalValue()
{
    double decimalValue = (double)_top / _bottom;
    return decimalValue;
}








}
