using MyFirstApplication;
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// single line comment
/*
 Multi-line comment
 The below statement is a local function. Local functions
 are inside of members and are private by default. This means
 they are specific to that member and can only be called
 inside that member.
 */
// Lesson Examples
//HouseExample();
void HouseExample()
{
    House myHouse = new House();
    myHouse.DoorOpenClose();
}
/*
 This local function is for my first exercise lab.
 */
//MyLocalFunction();
void MyLocalFunction()
{
    Console.WriteLine("This is my first sentence");
    Console.WriteLine("I am new to CSharp");
    Console.WriteLine("This CSharp course is cool");
    Console.WriteLine("I am learning stuff every day.");
}
//Lesson 1 Value Types
// Lesson1Example();
 void Lesson1Example()
{
    Lesson1 myLesson = new Lesson1();
    myLesson.IntMinMax();
    myLesson.IntegralExample();
    myLesson.ConvertFloatToInt();
    myLesson.LongFromInt();
}
// Lesson 1 Exercise 1
// Exercise1Example();
void Exercise1Example()
{
    Exercise1 exercise1 = new Exercise1();
    exercise1.Exercise1Task1();
    exercise1.Exercise1Task2();
    exercise1.Exercise1Task3();
}


// Lesson 2
// Lesson2Example();
void Lesson2Example()
{
    Lesson2 myLesson2 = new Lesson2();
    myLesson2.MyTrimExample();
    int able = myLesson2.MyStringLength();
    Console.WriteLine(able);
    myLesson2.MyEqualsExample("Hello World");
    myLesson2.MyExampleChar();
    Console.WriteLine(myLesson2.MyEscapeExample());
    myLesson2.MyJoinedStrings("CSharp", "Rules");
    Console.WriteLine(myLesson2.MyInterpolationExample("pizza", 3));
    myLesson2.MyOtherInterpolation();
}


//Exercise2
Exercise2Example();
void Exercise2Example()
{
    Exercise2 exercise2 = new Exercise2();
    exercise2.Exercise2Task1();
    exercise2.Exercise2Task2();
    exercise2.Exercise2Task3();
}