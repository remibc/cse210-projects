using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int number)
    {
        _top = number;
        _bottom = 1; 
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom; 
    }

    public string GetFractionString()
    {
        string form1 = $"{_top}/{_bottom}";
        return form1;
    }

    public double GetDecimalValue()
    {
        double form2 = (double)_top/(double)_bottom;
        return form2;
    }
}