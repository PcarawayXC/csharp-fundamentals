namespace MyFirstApplication;

internal class Exercise3
{
    public int Exercise3Task1(int val1)
    {
        Console.WriteLine(15 % val1);
        Console.WriteLine(456 % val1);
        return 23 % val1;
    }

    public void Exercise3Task2()
    {
        int alpha = (10 + 32 * 12 / 3);
        int beta = (alpha + 30);
        Console.WriteLine(alpha);
        Console.WriteLine(beta);
    }
    public void Exercise3Task3(int charlie, int delta)
    {
        Console.WriteLine(charlie += delta);
        Console.WriteLine(charlie /= delta);
        Console.WriteLine(charlie *= delta);
        Console.WriteLine(charlie %= delta);
    }
}
