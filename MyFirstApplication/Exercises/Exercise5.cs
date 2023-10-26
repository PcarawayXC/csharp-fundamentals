namespace MyFirstApplication;
internal class Exercise5
{
    public int Exercise5Task1(int alpha, int beta)
    {
        Func<int, int, int> voltage = (current, resistance) => current * resistance;
        int charlie = voltage(alpha, beta);
        Console.WriteLine(charlie);
        return charlie;
    }
    public string Exercise5Task2(char EVGAF2)
    {
        string result = EVGAF2 switch
        {
            'E' => "Excellent",
            'V' => "Very Good",
            'G' => "Good",
            'A' => "Average",
            'F' => "Fail",
            _ => "Not a valid grade"
        };
        Console.WriteLine(result);
        return result;
    }
    public void Exercise5Task3(int size)
    {
        string result = size switch
        {
            <=  3 => "Microwave bag",
            <= 16 => "Movie Sack",
            <= 32 => "Movie Cup",
            <= 64 => "Movie Tub",
            _ => "We don't have that size",
        };
        Console.WriteLine(result);
    }
}// end of class