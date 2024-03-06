namespace MyFirstApplication;
public class Polygon
{
    // properties
    protected int NumberOfSides{ get; set; }

    /*
     Base constructor. If a derived class does not implement
    a base class constructor explicitly, the base constructor
    is called implicitly
     */
    public Polygon()
    {
        NumberOfSides = 1;
    }
    /*
    this constructor will be accessed from the child class
    using the base in its constructor
     */
    public Polygon(int sides)
    {
        NumberOfSides = sides;
    }



    internal double CalculateInteriorAngle()
    {
        return ((NumberOfSides - 2) * 180 / NumberOfSides);
    }
} // end of class




// Square is the derived class of the Polygon
public class Square : Polygon
{
    public Square()
        : base(4)
    {
        //NumberOfSides = 4;
    }
} // end square class

//triangle class is dervied from the polygon
public class Triangle : Polygon
{
    public Triangle()
        : base(3)
    {
        //NumberOfSides = 3;
    }
} // end of triangle

