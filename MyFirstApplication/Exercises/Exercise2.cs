namespace MyFirstApplication;
    internal class Exercise2 
{
    string Exercise2lab = " EXERCISE two Lab ";
    public void Exercise2Task1()
    {
        Console.WriteLine(Exercise2lab.Trim());
        Console.WriteLine(Exercise2lab.ToLower());
        Console.WriteLine(Exercise2lab.Contains("tow"));
        Console.WriteLine(Exercise2lab.Length);
        Console.WriteLine(Exercise2lab.IndexOf('C'));
    }


    public void Exercise2Task2()
    {
        string PilcrowSign = "\u00B6";
        Console.WriteLine(PilcrowSign);
    }
    public void Exercise2Task3()
    {
        string JackAndJill = "Jack and Jill" +
            "\nwent up the hill" +
            "\nto fetch a pail of water." +
            "\nJack fell down and broke his crown" +
            "\nAnd Jill came tumbling after.";
        Console.WriteLine(JackAndJill);
    }



    



}// end of class

