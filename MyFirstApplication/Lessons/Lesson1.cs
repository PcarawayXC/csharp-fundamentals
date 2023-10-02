
namespace MyFirstApplication;

    /*
     This class goes over Value Types.
     */
    internal class Lesson1
{
    // Intergral Signed

    // sbyte range -128 to 127
    sbyte mySByte = 2;

    public void SByteMinMax()
    {
        Console.WriteLine(SByte.MinValue);
        Console.WriteLine(SByte.MaxValue);
    }
    //short range -32,768 to 32,767
    short myShort = 6;
    public void ShortMinMax()
    {
        Console.Write(Int16.MinValue);
        Console.Write(Int16.MaxValue);
    }

    // int range -2,147,483,648 to 2,147,483,647
    int myInt = 25685;
    public void IntMinMax()
    {
        Console.WriteLine(Int32.MinValue);
        Console.WriteLine(Int32.MaxValue);
    }

    //long range -9223,372,036,854,775,808 to 9,223,372,036,854,775,807
    long myLong = 123456789;
    public void LongMinMax()
    {
        Console.WriteLine(Int64.MinValue);
        Console.WriteLine(Int64.MaxValue);
    }


    // Intergral Unsigned

    //byte range 0 to 255
    byte myByte = 4;
    public void ByteMinMax()
    { 
    Console.WriteLine(Byte.MinValue);
    Console.WriteLine(Byte.MaxValue);
    }
    // ushort range 0 to 65,535
    ushort myUShort = 42;
    public void UShortMinMax()
    {
        Console.WriteLine(UInt16.MinValue);
        Console.WriteLine(UInt16.MaxValue);
    }
    //uint range 0 to 4,294,967,295
    uint myUInt = 4532U;
    public void UIntMinMax()
    {
        Console.WriteLine(UInt32.MinValue);
        Console.WriteLine(UInt32.MaxValue);
    }
    //  uLong range 0 to 18,446,744,073,709,551,615
    ulong myULONG = 948372UL;

    public void ULongMinMax()
    {
        Console.WriteLine(UInt64.MinValue);
        Console.WriteLine(UInt64.MaxValue);
    }

    // Floating Point / Real Numbers

    // float range 3.4E +/- 38
    float myFloat = -123.6589F;
    public void FloatMinMax()
    {
        Console.WriteLine(Single.MinValue);
        Console.WriteLine(Single.MaxValue);
    }

    // Double range 1.7E +/- 308
    double myDouble = 12.34D;
    public void DoubleMinMax()
    {
        Console.WriteLine(double.MinValue);
        Console.WriteLine(double.MaxValue);
    }
    //decimal range -7.9228E+24 to 7.9228E+24
    decimal MyDecimal = 13.23M;
    public void DecimalMinMax()
    {
        Console.WriteLine(Decimal.MinValue);
        Console.WriteLine(Decimal.MaxValue);
    }

    // Integral Literals
    public void IntegralExample()
    {
        // value of 26
        int value1 = 26; // decimal
        int value2 = 0x1a; // hexadecimal
        int value3 = 0b11010; // binary
        Console.WriteLine(value1);
        Console.WriteLine(value2);
        Console.WriteLine(value3);
    }

    // scientific notation
    double alpha = 6.26E-22;

    // underscores
    long beta = 1_834_432L;

    // explicit casting is where fractions are truncated and not rounded
    // you have to provide permission to cast from a higher type
    //to a lower type
    public void ConvertFloatToInt()
    {
        int converted = (int)myFloat;
        Console.WriteLine(converted);
    }

    //Implicit cast requires no direct permission
    public void LongFromInt()
    {
        long someValue = myInt;
        Console.WriteLine(someValue);
    }

}


