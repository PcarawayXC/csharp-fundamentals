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
// Exercise2Example();
void Exercise2Example()
{
    Exercise2 exercise2 = new Exercise2();
    exercise2.Exercise2Task1();
    exercise2.Exercise2Task2();
    exercise2.Exercise2Task3();
}
//Lesson3
//Lesson3Example();
void Lesson3Example()
{
    Lesson3 mylesson3 = new Lesson3();
    //mylesson3.BasicCheckedOperator(14);
    //mylesson3.BasicCheckedOperator2();
    //mylesson3.BasicUncheckedExample();
    //mylesson3.BasicMath();
    //mylesson3.BasicModulus(783);
    //mylesson3.BasicBooleanLogical(true, false);
    //mylesson3.BasicCompoundExample(12, 35, 9);
    //mylesson3.RelationalOperatorExample("Tom", "Tim");
    //mylesson3.MyIncrDecrExample();
}
// Exercise 3
//Exercise3Example();
void Exercise3Example()
{
    Exercise3 exercise3 = new Exercise3();
    exercise3.Exercise3Task1(67);
    exercise3.Exercise3Task2();
    exercise3.Exercise3Task3(24, 8);
}

Lesson4Example();
void Lesson4Example()
{
    Lesson4 lesson4 = new Lesson4();
    //lesson4.BasicIfStatement(11);
    //lesson4.BasicIfElseStatement(12);
    //lesson4.BasicIfElseChainStatement(5);
    //lesson4.BasicAndOrCondition(20,20);
    //Console.WriteLine(lesson4.BasicTernaryExample(35));
    //lesson4.BasicSwitchExample(2);
    //lesson4.BasicWhileStatement();
    //lesson4.BasicDoStatement();
    //lesson4.BasicForStatement();
    //lesson4.BasicForeachStatement();
    lesson4.BasicJumpStatement();
}