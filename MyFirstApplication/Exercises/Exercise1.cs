using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace MyFirstApplication;

public class Exercise1
{
   //task1 values
    int alpha = 35; //decimal
    int beta = 0x23; //hexadecimal
    int charlie = 0b0010_0011; //binary
    //task2 values
    byte delta = 32;
    short epsilon = 78;
    int foxtrot = 7632758;
    //task3 values
    double task3double = -29D; 
    float task3float = 451F;
    long task3long = -9879L;

    //task1
    public void Exercise1Task1()
    {
        Console.WriteLine(alpha);
        Console.WriteLine(beta);
        Console.WriteLine(charlie);
    }
    //task2
    public void Exercise1Task2()
    {
        int task2intconverted = delta;
        Console.WriteLine(task2intconverted);
        long task2longconverted = epsilon;
        Console.WriteLine(task2longconverted);
        float task2floatconverted = foxtrot;
        Console.WriteLine(task2floatconverted);
    }
    //task3
    public void Exercise1Task3()
    {
        long task3longconverted = (long)task3double;
        Console.WriteLine(task3longconverted);
        int task3intconverted = (int)task3float;
        Console.WriteLine(task3intconverted);
        short task3shortconverted = (short)task3long;
        Console.WriteLine(task3shortconverted);
    }
}