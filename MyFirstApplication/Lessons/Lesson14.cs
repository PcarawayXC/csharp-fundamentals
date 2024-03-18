namespace MyFirstApplication;

// Lesson 14 Arrays
internal class Lesson14
{
    // single dimension array
    public void SingleIntArray()
    {
        int[] intArray = { 2, 5, 34, 56, 28, 32 };

        foreach(int item in intArray)
        {
            Console.WriteLine(item);
        }
    }

    // single array of house
    public void SingleHouseArray()
    {
        House[] houseArray = new House[3];
        houseArray[0] = new House("concreate", "steel");
        houseArray[1] = new House();
        houseArray[2] = new House("dirt", "bamboo", "green", 33);

        foreach (House house in houseArray)
        {
            Console.WriteLine($"House Roof in the collection is {house.RoofType}");
        }
    }

    // Multi-Dimensional array
    public void MultiIntArray()
    {
        int[,] sampleInt = new int[2, 2];
        sampleInt[0, 0] = 2;
        sampleInt[0, 1] = 4;
        sampleInt[1, 0] = 6;
        sampleInt[1, 1] = 8;

        foreach(int item in sampleInt)
        {
            Console.Write($"{item}, ");
        }
    }

    // Multi-dimensional atring array using for loop.
    public void MultiStringArray()
    {
        string[,] myStringArray = { { "haapy", "coding", "day" }, { "sad", "deploy", "bugs" } };
        for(int i = 0; i < myStringArray.GetLength(0); i++)
        {
            for(int k = 0; k < myStringArray.GetLength(1); k++)
            {
                Console.WriteLine(myStringArray[i, k] );
            }
        }
    
    }

    // Jagged array is also an Array of arrays
    public void JaggedArraySample()
    {
        int[][] sampleArray = new int[3][];
        sampleArray[0] = new int[] { 2, 4 };
        sampleArray[1] = new int[] { 6, 8, 10 };
        sampleArray[2] = new int[] { 12, 14, 16, 18 };

        foreach (int[] items in sampleArray)
        {
            Console.WriteLine();
            foreach (int item in items)
            {
                Console.Write($"{item}, ");
            }
        }



    }



} // end class
