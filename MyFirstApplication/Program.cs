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
//Lesson4Example();
void Lesson4Example()
{
    Lesson4 lesson4 = new Lesson4();
    lesson4.BasicIfStatement(11);
    lesson4.BasicIfElseStatement(12);
    lesson4.BasicIfElseChainStatement(5);
    lesson4.BasicAndOrCondition(20,20);
    Console.WriteLine(lesson4.BasicTernaryExample(35));
    lesson4.BasicSwitchExample(2);
    lesson4.BasicWhileStatement();
    lesson4.BasicDoStatement();
    lesson4.BasicForStatement();
    lesson4.BasicForeachStatement();
    lesson4.BasicJumpStatement();
}
//Exercise4Example();
void Exercise4Example()
{
    Exercise4 exercise4 = new Exercise4();
    exercise4.Exercise4Task1("bricks", "yarn");
    exercise4.Exercise4Task1("carnival", "burnt toast");
    exercise4.Exercise4Task2('b');
    exercise4.Exercise4Task3();
}
//Lesson5Example();
void Lesson5Example()
{
    Lesson5 myLesson5 = new Lesson5();
    Lesson5.Del handler = myLesson5.DelegateMethod;
    Func<int, int> add = myLesson5.Sum;
    Console.WriteLine($"func example = {add(23)}");
    myLesson5.LambdaSquare();
    myLesson5.LambdaGreeting();
    Console.WriteLine(myLesson5.FavoriteColor("red"));
    Console.WriteLine(myLesson5.FavoriteColor("purple"));
    myLesson5.DrinkSize(24);
    myLesson5.TemperatureGuide(35.32);
    myLesson5.NumberChoice(9);
}
//Exercise5Example();
void Exercise5Example()
{
    Exercise5 myexercise5 = new Exercise5();
    myexercise5.Exercise5Task1(24, 54);
    myexercise5.Exercise5Task2('E');
    myexercise5.Exercise5Task3(45);
}
// Lesson6Example();
void Lesson6Example()
{
    // default constructor
    Lesson6 myLesson6 = new Lesson6();

    Lesson6 myLessonHats = new Lesson6("Cowboy", 7);
    Lesson6.TryOn theHat = myLessonHats.TryOnHat;
    theHat($"I tried on a {myLessonHats.HatType} hat that was size {myLessonHats.HatSize}");

    Console.WriteLine();

    // Constructor with 1 parameter
    Lesson6 myOther6 = new Lesson6(22);
    // Constructor with 2 paramters
    Lesson6 myHats = new Lesson6("Cowboy", 7);
    Console.WriteLine(myHats.HatSize);  // getting value
    myHats.HatSize = 5;                 // setting value

    // method parameter modifiers
    int able = 33, beta = 22, charlie;
    myLesson6.Inexample(able);
    myLesson6.RefExample(ref beta);
    Console.WriteLine(beta);
    myLesson6.OutExample(out charlie);
    Console.WriteLine(charlie);

    Console.WriteLine();

    // MultiCast Delegate
    Lesson6.TryOn theNewHat, hangTheHat, MultiHat;

    theNewHat = myLesson6.TryOnHat;
    hangTheHat = myLesson6.HangUpHat;
    MultiHat = theNewHat + hangTheHat;

    theNewHat($"Trying a {myLessonHats.HatType} hat");
    hangTheHat($"Hanging up my {myLessonHats.HatType} hat");
    MultiHat($"My {myLessonHats.HatType} hat");
}
// Exercise6Example();
void Exercise6Example()
{
    Exercise6 myExercise6 = new Exercise6();
    Exercise6 ShoeDetails = new Exercise6(11, "Adidas Sombas");
    Console.WriteLine($"My {ShoeDetails.ShoeType} are size {ShoeDetails.ShoeSize}");
    Exercise6.TryOn NewShoe;
    NewShoe = myExercise6.TryOnShoe;
    NewShoe($"I am trying on some shoes");
}

// Lesson7Example();
void Lesson7Example()
{
    // struct
    Location myLocation = new Location(34.5, 47.8);
    Console.WriteLine(myLocation.Latitude);
    Console.WriteLine(myLocation);

    // readonly struct
    Student myStudent = new Student(451, "Peyton");
    Console.WriteLine(myStudent);
    Console.WriteLine(myStudent.studentName);
    
    //Record
    Person person = new Person("Nancy", "Drew");
    Console.WriteLine(person);
    Console.WriteLine(person.LastName);

    // struct record
    Resolution res = new Resolution(1920, 1080);
    res.CalculateRes();
    Console.WriteLine(res);

}

// Exercise7Example();
void Exercise7Example()
{
    Exercise7Person myPerson = new Exercise7Person(451, "Peyton");
    Console.WriteLine(myPerson);
    Console.WriteLine(myPerson.Person2Name);
    Console.WriteLine(myPerson.Person2Id);

    Console.WriteLine();

    Exercise7Boat boat = new Exercise7Boat(17, "navy blue", "cloth");
    Console.WriteLine(boat.HullValue);
    Console.WriteLine(boat.SailColor);
    Console.WriteLine(boat.SailMaterial);
    boat.boatSteering();
}

// Lesson8Example();
void Lesson8Example()
{
    Lesson8 myLesson8 = new Lesson8(3);
    //  calling constant directly
    Console.WriteLine(Lesson8.DaysPerMonth);

    // Calculate Temperature (static class)
    Console.WriteLine(Lesson8Static.CelsiusToFahrenheit(45.6));
    Console.WriteLine(Lesson8Static.FahrenheitToCelsius(451));

    // Static methods
    Lesson8.DayCount = 10;
    myLesson8.CalculateHours();
    Lesson8.CalculateDayCount();
    Console.WriteLine($"The Calculation has been done {Lesson8.DayCount} times");

    // Static Lambda
    myLesson8.CalculateHoursV2();



}


// Exercise8Example();
void Exercise8Example()
{
    // Task 1
    // Convert the (number) of feet into inches
    Exercise8 myExercise8 = new Exercise8(1); // does this (number) matter, can it be anything?
    myExercise8.CalculateInches(3); // output 36
    myExercise8.CalculateInches(5); // output 60


    // Task 2
    Exercise8.AreaofPolygon(9, 18); 
}

// Lesson9Example();
void Lesson9Example()
{
    Lesson9 myLesson9 = new Lesson9();
    Lesson9.Nested nested = new Lesson9.Nested(myLesson9);

    // Access Modifiers
    myLesson9.SampleInternal();
    myLesson9.SampleProtectedInternal();
}

// Lesson10Example();
void Lesson10Example()
{
    Lesson10 myLesson10 = new Lesson10();
    // normal property
    myLesson10.FirstName = "Paul";
    Console.WriteLine(myLesson10.FirstName);

    // calling auto property
    // myLesson10.LastName = "Atreides"; // only works in Lesson10 constructor
    Console.WriteLine(myLesson10.Id); // default value
    myLesson10.Id = 4501;
    Console.WriteLine(myLesson10.Id);

    // expression body property
    myLesson10.Address = "123 Main St.";
    Console.WriteLine(myLesson10.Address);

    // second constructor
    Lesson10 myOther10 = new Lesson10("Ben", "Franklin", 64119);
    Console.WriteLine(myOther10.Zipcode);

}

HouseUpdated();
void HouseUpdated()
{
    //calling default
    House myHouse = new House();
    Console.WriteLine(myHouse.RoofType);
    myHouse.DoorOpenClose();
    Console.WriteLine();

    //calling constructor with two parameters
    House mySecond = new House("straw", "bamboo");
    Console.WriteLine(mySecond.WindowSize);
    mySecond.DoorOpenClose();
    Console.WriteLine();

    House myThird = new House("dirt", "plastic", "green", 40);
    Console.WriteLine(myThird.Foundation);
    myThird.DoorOpenClose();
}