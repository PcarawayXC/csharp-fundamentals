namespace MyFirstApplication;
//enum
public enum FavoriteMovies { PlanetOfTheApes, TheThing, BigTroubleInLittleChina, RRR, PerfectBlue, AClockworkOrange}



internal class Exercise15
{
    public string MovieMethod(FavoriteMovies movie)
    {
        string message = movie switch
        {
            FavoriteMovies.PlanetOfTheApes => $"My favorite movie is {FavoriteMovies.PlanetOfTheApes}.",
            FavoriteMovies.TheThing => $"My favorite movie is {FavoriteMovies.TheThing}.",
            FavoriteMovies.BigTroubleInLittleChina => $"My favorite movie is {FavoriteMovies.BigTroubleInLittleChina}.",
            FavoriteMovies.RRR =>$"My favorite movie is {FavoriteMovies.RRR}.",
            FavoriteMovies.PerfectBlue => $"My favorite movie is {FavoriteMovies.PerfectBlue}.",
            _ => $"My favorite movie is {FavoriteMovies.AClockworkOrange}.",
        };
        return message;
    }


    public (int able, string beta) Task2(FavoriteMovies movie)
    {
        int value1 = (int)FavoriteMovies.PlanetOfTheApes;
        string value2 = FavoriteMovies.TheThing.ToString();
        ToString();

        return (value1, value2);
    }



}
