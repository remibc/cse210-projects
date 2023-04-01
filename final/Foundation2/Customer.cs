using System;
public class Customer : Address
{
    protected string _Customer;

    public Customer() : base()
    {
        _Customer = "Customer 1";
    }

    public string information() 
    {
        return _Customer + Final(); 
    }

    public string location()
    {
        if (_Country == "USA")
        {
            return "USA";
        }
        else
        {
            return "Nothing";
        }
    }

}