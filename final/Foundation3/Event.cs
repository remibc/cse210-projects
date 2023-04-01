public class Event : Address
{
    private string _Event;
    private string _Description;
    private string _Date;
    private string _Time;
    private string _Address;
    public void Lecture()
    {
        _Event = "LECTURE";
        _Description = "Description 1";
        _Date = "March 23, 2023";
        _Time ="16:00 CST";
        _Address = Address1 ();
    }

    public void Reception()
    {
        _Event = "RECEPTION";
        _Description = "Description 2";
        _Date = "March 24, 2023";
        _Time ="16:00 CST";
        _Address = Address2 ();
    }

    public void Outdoor()
    {
        _Event = "OUTDOOR GATHERINGS";
        _Description = "Description 3";
        _Date = "March 25, 2023";
        _Time ="16:00 CST";
        _Address = Address3();
    }

    public void Print(string name)
    {
        Console.WriteLine($"{name}:\n\tName: {_Event}\n\tDescription: {_Description}\n\tDate: {_Date} \n\tTime: {_Time}\n\tAddress: {_Address}");
    }
    public void printShort(string name, string Type)
    {
        Console.WriteLine($"{name}:\n\tType: {Type}\n\tName: {_Event}\n\tDate: {_Date} \n\tTime: {_Time}");
    }
}