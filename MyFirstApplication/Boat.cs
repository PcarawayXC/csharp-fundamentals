namespace MyFirstApplication;
public class Boat
{
    //auto properties
    public string _hullType;
    public string _sailColor;
    public string _sailMaterial;
    public string _nameOfBoat;
    public int _nameFontSize;
    public string _nameFontColor;

    public string HullType { get => _hullType; set => _hullType = value; }
    public string SailColor { get => _sailColor; set => _sailColor = value; }
    public string SailMaterial { get => _sailMaterial; set => _sailMaterial = value; }
    public string NameOfBoat { get => _nameOfBoat; set => _nameOfBoat = value; }
    public int NameFontSize { get => _nameFontSize; set => _nameFontSize = value; }
    public string NameFontColor { get => _nameFontColor; set => _nameFontColor = value; }
    //constructor 1
    public Boat(string hullType, string sailColor, string sailMaterial, string nameOfBoat, int nameFontSize, string nameFontColor)
    {

        HullType = hullType;
        SailColor = sailColor;
        SailMaterial = sailMaterial;
        NameOfBoat = nameOfBoat;
        NameFontSize = nameFontSize;
        NameFontColor = nameFontColor;
    }

    //constructor 2
    public Boat(string nameOfBoat, int nameFontSize)
        : this("metal", "black", "plastic", nameOfBoat, nameFontSize, "White")
    { }

    // constructor 3
    public Boat()
        : this("wood", "off-white", "cloth", "PirateBay", 25, "White")
    { }

    public virtual void BoatSteers() // copy pasted from before
    {
        Random rnd = new Random();
        int boatsteer = rnd.Next(1, 4);
        if (boatsteer == 1) { Console.WriteLine("The Boat turned left"); }
        else if (boatsteer == 2) { Console.WriteLine("The Boat turned right"); }
        else { Console.WriteLine("The Boat remains forward"); }
    }
    public void BoatSteers(string nameOfBoat)
    {
        Console.WriteLine($"{nameOfBoat} crashes onto shore");
    }
} // end of boat



public class SailBoat : Boat
{
    //expression body definitions
    int _topSpeed;
    public int TopSpeed
    {
        get => _topSpeed; set => _topSpeed = value;
    }

    //constructor 1
    public SailBoat(string hullType, string sailColor, string sailMaterial, string nameOfBoat, int nameFontSize, string nameFontColor, int topSpeed)
        : base(hullType, sailColor, sailMaterial, nameOfBoat, nameFontSize, nameFontColor)
    {
        TopSpeed = topSpeed;
    }

    //constructor 2
    public SailBoat(string sailColor, string nameFontColor, int topSpeed)
        : this("plastic", sailColor, "cloth", "Big Johnny", 42, nameFontColor, topSpeed)
    {    }

    // constructor 3
    public SailBoat()
        : this("metal", "navy blue", "aluminum", "Morning Glory", 46, "white", 72)
    { }
    public void Iceberg()
    {
        Console.WriteLine("An icebreg is in the path");
    }
    public override void BoatSteers()
    {
        Console.WriteLine("The boat's steering is jammed");
    }
}