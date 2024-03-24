namespace MyFirstApplication;

internal class Exercise17
{
    public void task1(int alpha, int beta)
    {
        int charlie;
        try
        {
            charlie = alpha / beta;
            Console.WriteLine(charlie);
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Divide by Zero detected: {ex.Message}");
        }
    }
    public void task2(Horse horse)
    {
        if (horse == null)
        {
            throw new NullReferenceException("Horse object is null");
        }
        else
        {
            Console.WriteLine(horse.HorseAge);
        }
    }



}
