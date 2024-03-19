namespace MyFirstApplication;
internal class Exercise14
{
    public void IceCreamArray()
    {
        string[] icecream = { "vanilla", "chocolate", "strawberry", "turtle", "dirt'n'worms" };

        foreach (string item in icecream)
        {
            Console.WriteLine(item);
        }
    }// end icecream

    public void FootballArray()
    {
        int[,] scores = { { 17, 22 }, { 38, 24 }, {9, 31}, { 34, 20 }, { 23, 20 }, { 34, 20 }, { 26, 10 }, { 23, 40 }, 
            { 26, 17 }, { 43, 16 }, { 35, 9 }, { 33, 31 }, { 35, 31 }, { 27, 24 }, { 22, 16 }, { 33, 27 }, { 32, 29 }, 
            { 17, 14 }, { 21, 38 } };

        // challenge results
        for(int i = 0; i < scores.GetLength(0); i++)
        {
            for(int k = 0; k < scores.GetLength(1); k++)
            {
                // Console.WriteLine($"{i} {k}");
                // Console.WriteLine(scores[i, k]);
                if (k == 0)
                {
                    // [this number, not this]
                    Console.Write($"Chiefs: {scores[i, k]} ");
                }
                else
                {
                    // [not this, this number]
                    Console.WriteLine($"Enemy: {scores[i, k]}");
                }
            }
        }
        
        /* 
         * basic foreach to write it all out
        foreach(int item in scores)
        {
            Console.WriteLine(item);
        }
        */

        
    } // end footbal






}// end class