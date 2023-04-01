public class Full : Event
{
    public Full()
    {
        Lecture ();
        Print ("LECTURE");
        Console.WriteLine("\tSpeaker: Remi Barron\n\tCapacity: Limited");
        Reception ();
        Print ( "RECEPTION");
        Console.WriteLine("\tEmail: RSVP@gmail.com");
        Outdoor();
        Print ("OUTDOOR");
        Console.WriteLine("\tWeather: Partly Cloudy");

    }
}