namespace MyFirstApplication;
internal class Exercise8
{
    // const variables
    public const int Inches = 12; // inches in a foot

    private int _feet;
    public Exercise8(int feet)
    {
        _feet = feet;
    }


    // task 1 (parameter * Inches, output # of inches in total feet)
    public void CalculateInches(int _feet)
    {
        Func<int, int> totalInches = static value => Inches * value;
        Console.WriteLine($"totalInches = {totalInches(_feet)}");
    }


    // task 2 (length * width of polygon for area)
    public static void AreaofPolygon(int width, int length)
    {
        int area = (width * length);
        Console.WriteLine($"Using the width of {width} and length " +
            $"of {length} the area of the rectangular polygon is {area} ");
    }
}
