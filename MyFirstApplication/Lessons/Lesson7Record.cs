namespace MyFirstApplication;
/*
 A Record is a reference type that provides built-in functionality
 for ecnapsulating data
*/
internal record Person(string FirstName, string LastName);

/*
 A record struct is a value type with similar functionality as a record class
*/
public record struct Resolution(int width, int height)
{
    public void CalculateRes()
    {
        Console.WriteLine(width * height);
    }
} // end record

