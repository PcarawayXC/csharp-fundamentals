using MyFirstApplication;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// The below statement calls a local function
// single line comment

/*
 Multi-line comment
 The below statement is a local function. Local functions
 are inside of members and are private by default. This means
 they are specific to that member and can only be called
 inside that member.
 */

// Lesson Examples
// HouseExample();
void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}
/*
 This local function is for myfirst exercise lab.
 */
// MyLocalFunction();
void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff every day.");
}





//Lesson 1 Value Types
Lesson1Example();
void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}