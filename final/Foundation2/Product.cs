using System;
public class Product
{
    protected string _Name;
    protected string _ID;
    protected double _Price;
    protected double _Qty;
    
    public Product()
    {
        _Name = "Product 1";
        _ID = "1001";
        _Price = 1;
        _Qty = 1;
    }
    public Product(string test)
    {
        _Name = "Product 2";
        _ID = "1002";
        _Price = 2;
        _Qty = 2;
    }
    public Product(int test)
    {
        _Name = "Product 3";
        _ID = "1003";
        _Price = 3;
        _Qty = 3;
    }

    public string getName()
    {
        return _Name;
    }
    public string getID()
    {
        return _ID;
    }
    public double getPrice()
    {
        return _Price;
    }
    public double getQty()
    {
        return _Qty;
    }
}


