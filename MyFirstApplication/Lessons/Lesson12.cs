namespace MyFirstApplication;

// base class with a method declared virtual for overriding
public class Fruit
{
    public virtual void EatFruit()
    {
        Console.WriteLine("I eat fruit.");
    }

    public void EatFruit(int quantity)
    {
        Console.WriteLine($"I eat {quantity} portions of fruit");
    }
} //end fruit class


// derived class overriding the base class method
public class Apple : Fruit
{
    public override void EatFruit()
    {
        base.EatFruit(4);
        Console.WriteLine("I eat apples.");
    }

} // end apple class