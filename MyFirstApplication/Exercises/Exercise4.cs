namespace MyFirstApplication;
internal class Exercise4
{
    public void Exercise4Task1(string alpha, string beta)
    {
        if (alpha == beta) { Console.WriteLine($"{alpha} is equal to {beta}"); }
        else { Console.WriteLine($"{alpha} is not equal to {beta}"); }
    }
    public string Exercise4Task2(char EVGAF)
    {
        switch (EVGAF)
        {
            case 'E':
                Console.WriteLine("Excellent");
                break;
            case 'V':
                Console.WriteLine("Very Good");
                break;
            case 'G':
                Console.WriteLine("Good");
                break;
            case 'A':
                Console.WriteLine("Average");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default: Console.WriteLine("Not a valid grade");
                break;
        }
        return $"{EVGAF}";
    }
    public void Exercise4Task3()
    {
        for (int i = 0; i <= 100; i++) 
        {
            int modu = i % 3;
            if (modu == 0) { Console.WriteLine($"{i}"); }
        }
    }
} // end of class