using System.Runtime.CompilerServices;

namespace MyFirstApplication;
public class Horse
{
    // auto properties
    public int HorseAge { get; init; }
    public string CoatPattern { get; init; }
    public string ManeColor {  get; init; }
    public int TopVelocity { get; init; }
    public int AccelerationRate { get; init; }
    public int CaloricIntake { get; init; }


    // constructor 3
    public Horse()
    : this(15, "spotted", "black", 75, 23, 15060)
    { }
    //constructor 2
    public Horse(string maneColor, int caloricIntake)
    : this(19, "patchy", maneColor, 32, 12, caloricIntake)
    { }
    // constructor 1
    public Horse(int horseAge, string coatPattern, string maneColor, int topVelocity, int accelerationRate, int caloricIntake)
    {
        HorseAge = horseAge;
        CoatPattern = coatPattern;
        ManeColor = maneColor;
        TopVelocity = topVelocity;
        AccelerationRate = accelerationRate;
        CaloricIntake = caloricIntake;
    }
    public virtual void HorseEats(int caloricIntake)
    {
        Console.WriteLine($"Horse eats {caloricIntake} of calories");
    }
    public void HorseEats()
    {
        Console.WriteLine("The horse starves.");
    }


} // end of Horse


public class Pony : Horse
{
    //child auto prop
    public int HorseHeight { get; init; }
    // constructor 3
    public Pony()
        : this(12, "solid", "white", 33, 11, 1350, 72)
    {
        
    }
    
    //constructor 2
    public Pony(int horseAge, int topVelocity, int horseHeight)
        : this(horseAge, "striped", "light brown", topVelocity, 11, 1400, horseHeight)
    { }
    // constructor 1
    public Pony(int horseAge, string coatPattern, string maneColor, int topVelocity, int accelerationRate, int caloricIntake, int horseHeight)
        : base(horseAge, coatPattern, maneColor, topVelocity, accelerationRate, caloricIntake)
    {
        HorseHeight = horseHeight;
    }
    
    public void IfInjured(int horseAge)
    {
        if (horseAge > 44) { Console.WriteLine("The horse is too old, take it out back"); }
        else { Console.WriteLine("The horse is not too old"); }
    }
    public override void HorseEats(int caloricIntake)
    {
        Console.WriteLine($"The pony struggles to eat {caloricIntake} of food");
    }


} // end of pony
