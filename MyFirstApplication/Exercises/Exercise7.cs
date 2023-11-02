namespace MyFirstApplication;
internal struct Exercise7Person
{
    //variables
    private int _id; private string _name;
    public int Person2Id
    {
        get { return _id; }
        set { _id = value; }
    }
    public string Person2Name
    {
        get { return _name; }
        set { _name = value; }
    }
    public Exercise7Person(int Person2Id, string Person2Name)
    {
        _id = Person2Id;
        _name = Person2Name;
    }
} // end of struct

public record Exercise7Boat(int HullValue, string SailColor, string SailMaterial)
{
    public void boatSteering()
    {
        Console.WriteLine("You steer the boat in a random direction");
        Random rnd = new Random();
        int boatsteer = rnd.Next(1, 4);
        if (boatsteer == 1) { Console.WriteLine("The Boat turned left"); }
        else if (boatsteer == 2) { Console.WriteLine("The Boat turned right"); }
        else { Console.WriteLine("The Boat remains forward"); }
    }
} // end of record
