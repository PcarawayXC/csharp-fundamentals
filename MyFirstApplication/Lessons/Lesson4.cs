using System.Security.Cryptography.X509Certificates;

namespace MyFirstApplication;
/*
 Lesson 4 - Control Flow Statements
 */
internal class Lesson4
{
    // basic if statement
    public void BasicIfStatement(int value)
    {
        Console.WriteLine("Before if statement");
        if (value > 10) { Console.WriteLine($"Our {value} was greater than 10."); }
        Console.WriteLine("After if statement");
    }

    // basic if-else statement
    public void BasicIfElseStatement(int able)
    {
        if(able >= 15) { Console.WriteLine($"Our {able} is greater than 15"); }
        else { Console.WriteLine($"Our {able} is was less than 15"); }
    }

    // basic if-else chain
    public void BasicIfElseChainStatement(int beta)
    {
        if(beta == 10) { Console.WriteLine($"Our {beta} is 10.");}
        else if(beta == 20) { Console.WriteLine($"Our {beta} is 20."); }
        else { Console.WriteLine($"Our {beta} is not the same."); }
    }

    // basic if with Boolean Logical Operators
    public void BasicAndOrCondition(int charlie, int delta)
    {
        if(charlie > 15 && delta < 30) { Console.WriteLine($"{charlie} and {delta}"); }
        if(charlie == 18 || delta < 25) {  Console.WriteLine($"{charlie} or {delta}"); }
    }

    // Ternary Operator
    public bool BasicTernaryExample(int echo)
    {
        return (echo > 30) ? true : false; 
    }

    // Switch Statement Example
    public void BasicSwitchExample(int foxtrot)
    {
        switch (foxtrot)
        {
            case 1:
            case 2:
                Console.WriteLine($"{foxtrot} is 1 or 2");
                break;
            case 3:
                Console.WriteLine($"{foxtrot} is 3");
                break;
            case 4:
                Console.WriteLine($"{foxtrot} is 4");
                break;
            default:
                Console.WriteLine($"{foxtrot} was not in the list");
                break;
        }
    }

    //While Statement
    public void BasicWhileStatement()
    {
        int fox = 0; // initialization
        while(fox < 10)
        {
            Console.WriteLine($"While Number = {fox}");
            fox++; // Increment
        }
    }

    // do statement
    public void BasicDoStatement()
    {
        int hotel = 0;
        do
        {
            Console.WriteLine($"Do Number = {hotel}.");
            hotel++;
        } while (hotel < 13);
    }

    // For Statement
    public void BasicForStatement()
    {
        for(int gecko = 0; gecko < 11; gecko++)
        {
            Console.WriteLine($"Number = {gecko}");
        }
    }

    // Foreach statement
    public void BasicForeachStatement()
    {
        foreach(char word in "Something")
        {
            Console.WriteLine($"Char value = {word}");
        }
    }

    // Jump statements
    public void BasicJumpStatement()
    {
        for(int i = 0; i < 10; i++)
        {
            if(i == 2)
            {Console.WriteLine($"The {i} was skipped"); continue;}
            if(i == 4) { Console.WriteLine($"The Loop breaks at {i}"); break; }
            Console.WriteLine($"Number = {i}");
        }
    }

} // end of class