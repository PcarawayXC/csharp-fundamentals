﻿namespace MyFirstApplication;
public class House
{
    public string Foundation { get; init; }
    public string RoofType { get; init; }
    public string DoorColor { get; init; }
    public int WindowSize { get; init; }

    public House()
        :this("concrete", "shingle")
    { }

    public House(string foundation, string roofType)
        : this(foundation, roofType, "Red", 25)
    { }

    public House(string foundation, string roofType, string doorColor, int windowSize)
    {
        Foundation = foundation;
        RoofType = roofType;
        DoorColor = doorColor;
        WindowSize = windowSize;
    }

    

    public virtual void DoorOpenClose()
    {
        Console.WriteLine($"My {DoorColor} door is open.");
    }
}
