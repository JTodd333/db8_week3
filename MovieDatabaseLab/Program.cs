Console.WriteLine("Welcome to the Movie List Application!");
Console.WriteLine();

List<Movie> inventory = new List<Movie>();

inventory.Add(new Movie("Jurassic Park", "Sci-Fi", 1993, 127));
inventory.Add(new Movie("The Matrix", "Sci-Fi", 1999, 136));
inventory.Add(new Movie("Signs", "Sci-Fi", 2002, 106));
inventory.Add(new Movie("Lion King", "Animated", 1994, 88));
inventory.Add(new Movie("The Nightmare Before Christmas", "Animated", 1993, 76));
inventory.Add(new Movie("Shrek", "Animated", 2001, 90));
inventory.Add(new Movie("Forrest Gump", "Drama", 1994, 142));
inventory.Add(new Movie("Cast Away", "Drama", 2000, 143));
inventory.Add(new Movie("The Ring", "Horror", 2002, 115));
inventory.Add(new Movie("The Grudge", "Horror", 2004, 91));



Console.WriteLine($"There are {inventory.Count} movies in this list.");

List<string> genres = new List<string>();
foreach (Movie next in inventory)
{
    if (genres.IndexOf(next.Genre) == -1)
    {
        genres.Add(next.Genre);
    }
}
genres.Sort();

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


    if (entry == "Sci-Fi" || entry == "Animated" || entry == "Drama" || entry == "Horror")
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
        Console.WriteLine();
        Console.Write("Would you like to go again? (y/n): ");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            Console.WriteLine();
            return true;
        }
        else if (response == "n" || response == "no")
        {
            Console.WriteLine("Goodbye!");
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}



//Class info


class Movie
{
    public string Title;
    public string Genre;
    public int Year;
    public int Runtime;

    public Movie(string _Title, string _Genre, int _Year, int _Runtime)
    {
        Title = _Title;
        Genre = _Genre;
        Year = _Year;
        Runtime = _Runtime;
    }

    public override string ToString()
    {
        return $"{Title} - {Year} ({Genre}) [Runtime: {Runtime} min]";
    }
}