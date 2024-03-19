namespace MyFirstApplication;

/*
 Enums can be created either within a class or struct
or in the namespace
 */
public enum Day { Sat, Sun, Mon, Tue, Wed, Thu, Fri };
public enum IcecreamFlavors { Vanilla, Chocolate, Strawberry, RockyRoad};

// Lesson 15 Enums and Tuples
internal class Lesson15
{
    public void EnumExample()
    {
        Console.WriteLine(Day.Mon); // displays value
        Console.WriteLine((double)Day.Tue); // displays number value
    }

    // enum using a switch expression to narrow down choices
    public string FavoriteIcecream(IcecreamFlavors flavors)
    {
        string message = flavors switch
        {
            IcecreamFlavors.Vanilla => $"My favorite is {IcecreamFlavors.Vanilla}",
            IcecreamFlavors.Chocolate => $"My favorite is {IcecreamFlavors.Chocolate}",
            IcecreamFlavors.Strawberry => $"My favorite is {IcecreamFlavors.Strawberry}",
            _ => $"My favorite is {IcecreamFlavors.RockyRoad}"
        };
        return message;
    }

    /*
     Tuples aare a group of types using parantheses and separating with a comma.
     */
    public void TupleExample()
    {
        (double, int) able = (2.3, 5);
        Console.WriteLine($"Tuple with elements {able.Item1} and {able.Item2}");

        (double value1, double value2) beta = (3.3, 5.4);
        Console.WriteLine($"The second Tuple with elements {beta.value1} and {beta.value2}");
    }


    /*
     using a tuple to return multiple results in a method
     */
    public (int able, int bet, int delta) TupleReturnExample(int value1, int value2)
    {
        int alpha, bravo, charlie;
        if(value1 >=10 || value2 <= 50)
        {
            alpha = ++value1;
            bravo = ++value2;
            charlie = alpha + bravo;
        }
        else
        {
            alpha = 1;
            bravo = 2;
            charlie = 3;
        }
        return (alpha, bravo, charlie);


    }



} // end of class
