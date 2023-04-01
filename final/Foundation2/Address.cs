using System;
public class Address
{
    protected string _Street;
    protected string _City;
    protected string _State;
    protected string _Country;

    public Address()
    {
        _Street = "410 Terry Ave N";
        _City = "Seattle";
        _State = "WA";
        _Country = "USA";

    }

    public string Final()
    {
        return $"\n{_Street}\n{_City}, {_State}, {_Country}";
    }

    public string Country()
    {
        return _Country;
    }

}