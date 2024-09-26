using TPSWebAPI;

OmdbApiClient omdbClient = new OmdbApiClient();
Console.Write("Enter Movie Name: ");
string movieTitle = Console.ReadLine();

OMDBMovie movieData = await omdbClient.GetMovieDataAsync(movieTitle);

if (movieData != null)
{
    Console.WriteLine($"Movie Title: {movieData.Title}");
    Console.WriteLine($"Movie Plot: {movieData.Plot}");
    Console.WriteLine($"Movie Director: {movieData.Director}");
    foreach (Rating rating in movieData.Ratings)
    {
        Console.WriteLine($"\tSource: {rating.Source}\tValue: {rating.Value}");
    }
}