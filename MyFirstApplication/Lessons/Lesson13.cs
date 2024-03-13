namespace MyFirstApplication;
/*
 this will be about Abstract modifier and Interfaces
 */
public interface ILesson13Interface
{
    int Miles { get; }
    int ConvertMilestoYards();
} // end interface

internal abstract class Lesson13Base : ILesson13Interface
{
    protected int num;

    // abstract properties
    protected abstract int Inches {  get; }
    protected abstract int Feet { get; }
    //implemented from interface
    public abstract int Miles { get; }

    protected Lesson13Base(int num)
    {
        this.num = num;
    }

    // Abstract Methods
    public abstract int ConvertFeetToInches();
    public abstract int ConvertYardsToFeet();
    // implemented from interface
    public abstract int ConvertMilestoYards();


} // end lesson13base class
/*
 our derived class will implement out Abstract class members
 */
internal class Lesson13Derived : Lesson13Base
{
    // implementing abstract properties
    protected override int Inches { get; } = 12; // inches in a foot
    protected override int Feet { get; } = 3; // feet in a yard
    //implementing interface
    public override int Miles { get; } = 1760; // yards in a mile

    public Lesson13Derived(int value)
    :base(value) { }

    // Implementing abstract methods
    public override int ConvertFeetToInches()
    {
        return num * Inches;
    }
    public override int ConvertYardsToFeet()
    {
        return num * Feet;
    }
    // implemented interface method
    public override int ConvertMilestoYards()
    {
        return num * Miles;
    }
} // end lesson13derived class


