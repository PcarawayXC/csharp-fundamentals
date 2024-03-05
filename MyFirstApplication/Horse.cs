namespace MyFirstApplication;
internal class Horse
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
    public void HorseEats(int caloricIntake)
    {
        Console.WriteLine($"Horse eats {caloricIntake} of calories");
    }
} // end of class