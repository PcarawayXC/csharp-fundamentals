namespace MyFirstApplication;

internal class Exercise16
{
    public void task1()
    {
        List<string> horseObject = new List<string>();
        horseObject.Add("Horse age");
        horseObject.Add("Coat pattern");
        horseObject.Add("Mane color");
        horseObject.Add("Top velocity");
        horseObject.Add("Acceleration rate");
        horseObject.Add("Caloric intake");

        foreach(string item in horseObject)
        {
            Console.WriteLine(item);            
        }
    }

    public void task2()
    {
        Dictionary<int, string> movies = new Dictionary<int, string>();
        movies.Add(23, "Planet of the Apes");
        movies.Add(41, "The Thing");
        movies.Add(12, "Big Trouble in Little China");
        movies.Add(3, "RRR");
        movies.Add(72, "Perfect Blue");

        foreach(KeyValuePair<int, string> item in movies)
        {
            Console.WriteLine($"{item.Value} is arbitrarily assigned {item.Key}");
        }




    }


}
