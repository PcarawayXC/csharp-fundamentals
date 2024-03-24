namespace MyFirstApplication;

internal class Lesson17
{
    public void MyThrowExample(House house)
    {
        if (house == null)
        {
            throw new NullReferenceException("House object is null");
        }
        else
        {
            Console.WriteLine(house.DoorColor);
        }
    }

    // this example will use a try/catch
    public void MyExceptionExample(House house)
    {
        try
        {
            Console.WriteLine($"The House door color is {house.DoorColor}");
        }
        catch(NullReferenceException ex)
        {
            Console.WriteLine($"Null reference was thrown: {ex.Message}");
        }
    }



    public void MyArrayException()
    {
        string[] names = { "David", "Matt", "Jody" };
        string[] values = { "257", "425", "385" };

        try
        {
            byte beta = byte.Parse(values[1]);
            Console.WriteLine(beta);
        }
        catch (IndexOutOfRangeException ex)
        {
            Console.WriteLine($"Please try atleat 1 arguement: {ex.Message}");
        }
        catch (FormatException fe)
        {
            Console.WriteLine($"That is not a number: {fe.Message}");
        }
        catch (OverflowException oe)
        {
            Console.WriteLine($"You have given me more than one byte: {oe.Message}");

        }
        finally
        {
            Console.WriteLine("The finally block has been executed");
        }

    }












} // end class
