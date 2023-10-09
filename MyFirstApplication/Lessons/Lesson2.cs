namespace MyFirstApplication;

/*
 this class goes over strings
 */
internal class Lesson2
{
    string myString = "Hello World";

    // string method - Trim
    public void MyTrimExample()
    {
        string str = "  Word  ";
        // before trim
        Console.WriteLine(str);

        //after trim
        string myTrim = str.Trim();
        Console.WriteLine(myTrim);
    }

    //string method - Equals
    public void MyEqualsExample(string beta)
    {
        Console.WriteLine(beta.Equals("World"));
    }

    //string methods ToUpper and ToLower
    public void MyUpperLowerExample()
    {
        Console.WriteLine(myString.ToUpper());
        Console.WriteLine(myString.ToLower());
    }

    //string method - Length
    public int MyStringLength()
    {
        return myString.Length;
    }


    // Char - uses single quotes
    public void MyExampleChar()
    {
        char myChar = 't';
        char copyright = '\u00A9';
        char something = '\x00AE';
        Console.WriteLine(something);
        Console.WriteLine(myChar);
        Console.WriteLine(copyright);
    }



    // escape sequence
    public string MyEscapeExample()
    {
        return "That\'s a cool car. \tCan I \ndrive it sometime?";
    }

    //concatenation - with 2 string parameters
    public void MyJoinedStrings(string value1, string value2)
    {
        Console.WriteLine(value1 + " " + value2);
    }

    // string interpolation
    public string MyInterpolationExample(string food, int amount)
    {
        return $"My Favorite food is {food} and I ate {amount} servings of it";
    }

   
    // ($"|{"Number", -10} | {"Order", 15}|");
    public void MyOtherInterpolation()
    {
        Console.WriteLine($"|{"Number", -10} | {"Order", 15}|");
    }


} // end Lesson2 Class
