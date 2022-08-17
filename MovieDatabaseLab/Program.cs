Console.WriteLine("Welcome to the Movie Application!");
Console.WriteLine();

List<Movie> inventory = new List<Movie>();

inventory.Add(new Movie("Jurassic Park", "Sci-Fi", 1993));
inventory.Add(new Movie("The Matrix", "Sci-Fi", 1999));
inventory.Add(new Movie("Signs", "Sci-Fi", 2002));
inventory.Add(new Movie("Lion King", "Animated", 1994));
inventory.Add(new Movie("The Nightmare Before Christmas", "Animated", 1993));
inventory.Add(new Movie("Shrek", "Animated", 2001));
inventory.Add(new Movie("Forrest Gump", "Drama", 1994));
inventory.Add(new Movie("Cast Away", "Drama", 2000));
inventory.Add(new Movie("The Ring", "Horror", 2002));
inventory.Add(new Movie("The Grudge", "Horror", 2004));

Console.WriteLine($"There are {inventory.Count} movies in this list.");

List<string> genres = new List<string>();
foreach (Movie next in inventory)
{
    if (genres.IndexOf(next.Genre) == -1)
    {
        genres.Add(next.Genre);
    }
}

do
{

    Console.WriteLine("The Genres we have are:");

    foreach (string genre in genres)
    {
        Console.WriteLine(genre);
    }

    Console.WriteLine();
    Console.Write("What category are you interested in? ");
    //Console.WriteLine("[1] Sci-Fi   [2] Animated   [3] Drama   [4] Horror");
    //bool ValidNum = int.TryParse
    string entry = Console.ReadLine();


    if (entry == "Sci=Fi" || entry == "Animated" || entry == "Drama" || entry == "Horror")
    {
        foreach (Movie next in inventory)
        {
            if (next.Genre == entry)
            {
                Console.WriteLine(next);
            }
        }
    }
    else
    {
        Console.WriteLine("Sorry, we don't have that movie genre. Try again.");
    }
} while (KeepGoing());

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}









static Movie FindMovie(List<Movie> movielist, string moviegenre)
{
    foreach(Movie next in movielist)
    {
        if (next.Genre.ToLower() == moviegenre.ToLower())
        {
            return next;
            //List<Movie> Result = new List<Movie>(movielist.FindAll(next.Genre));
        }
        
    }
    return null;
}

class Movie
{
    public string Title;
    public string Genre;
    public int Year;

    public Movie(string _Title, string _Genre, int _Year)
    {
        Title = _Title;
        Genre = _Genre;
        Year = _Year;
    }

    public override string ToString()
    {
        return $"{Title} in Genre {Genre}, {Year}";
    }
}