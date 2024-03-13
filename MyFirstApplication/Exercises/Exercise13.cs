namespace MyFirstApplication;
public interface IMovement
{
    int Speed { get; init; }
}
internal abstract class WaterBirds : IMovement
{
    // implement the interface int property
    public abstract int Speed { get; init; }
    

    //create two abstract methods related to waterbirds
    
    public abstract void FlightSpeed(int Speed);

    public abstract void FlightDestination();
    protected WaterBirds(int Speed)
    {
        this.Speed = Speed;
    }
}


// child of WaterBirds
internal class BabyBird : WaterBirds
{
    public BabyBird(int Speed)
        : base(Speed) { }
    // implement abstract proprty
    public override int Speed { get; init;  }

    // implement abstract methods
    public override void FlightSpeed(int Speed)
    {
        Console.WriteLine($"The bird flew {Speed} miles in an hour");
    }
    public override void FlightDestination()
    {
        Console.WriteLine("The birds arrive in Mexico");
    }


}