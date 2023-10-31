namespace MyFirstApplication;
internal class Exercise6
{
    // task 1
    private int _shoeSize;
    private string _shoeType;
    public Exercise6(int shoeSize, string shoeType)
    {
        _shoeSize = shoeSize;
        _shoeType = shoeType;
    }

    // task 2
    public string ShoeType
    {
        get { return _shoeType; }
        set { _shoeType = value; }
    }
    public int ShoeSize
    {
        get { return _shoeSize; }
        set { _shoeSize = value; }
    }

    //task 3
    public delegate void TryOn(string type);
    public Exercise6()
    {
        TryOn tryOn = TryOnShoe;
    }
    public void TryOnShoe(string message)
    {
        Console.WriteLine(message);
    }
} // End of Class