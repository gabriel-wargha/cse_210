class Bin 
{
    private string _denomination;
    private double _value;
    private int _count;

    public Bin (string d, double v, int c)
    {
         _denomination = d;
        _value = v
        _count = c;
    }

    public void Transaction(int _count) 
    //Value parameter Negative for debit, positive for credit
    {
        _count += count;
    }

    public int GetCount()
    {
        return _count;
    }

    public string getDenomination{
        return _denomination;
    }

    public double GetValue()
    {
        return _value;
    }
}


