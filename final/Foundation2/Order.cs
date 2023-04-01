using System;
public class Order : Customer
{
    private double _Total;

    public Order () : base()
    {

    }
    public void Shipping()
    {
        Console.WriteLine("***UPS FISRT CLASS PKG***");
        Console.WriteLine("-------------------------");
        Console.WriteLine("Remi Barron\nPresa Rejon\nCUU,MX 31510\n");
        Console.WriteLine($"Shp to:\t\n{information()}\n");
        Console.WriteLine($"||||||||||||||||||||");
        Console.WriteLine($"12323423452456345656");
    }

    public void Packing1 ()
    {
        Console.WriteLine("***Packing Label***");
        Console.WriteLine("ITEMS:");
        List<Product> _List = new List<Product>();
        Product P1 = new Product();
        _List.Add(P1);
        Product P2 = new Product("test");
        _List.Add(P2);

        foreach (Product Print in _List)
        {
            _Total = _Total + (Print.getPrice()*Print.getQty());
            Console.WriteLine($"\t{Print.getName()}..{Print.getID()}");
        }
        Console.WriteLine($"||||||||||||||||||||");
        Console.WriteLine($"12323423452456345656");
        if (_Country =="USA")
        {
            _Total = _Total + 5;
        }
        else
        {
            _Total = _Total + 35;
        }
    }

    public void Packing2 ()
    {
        Console.WriteLine("***Packing Label***");
        Console.WriteLine("ITEMS:");
        List<Product> _List = new List<Product>();
        Product P1 = new Product();
        _List.Add(P1);
        Product P2 = new Product("test");
        _List.Add(P2);
        Product P3 = new Product(1);
        _List.Add(P3);

        foreach (Product Print in _List)
        {
            _Total = _Total + (Print.getPrice()*Print.getQty());
            Console.WriteLine($"\t{Print.getName()}..{Print.getID()}");
        }
        Console.WriteLine($"||||||||||||||||||||");
        Console.WriteLine($"12323423452456345656");

        if (_Country =="USA")
        {
            _Total = _Total + 5;
        }
        else
        {
            _Total = _Total + 35;
        }
    }

    public double Total ()
    {
        return _Total;
    }
}