//Ad the using line manually. The name comes from
//the "namespace" line in the Movie.cs file.

using MovieDatabaseJeffVersion;

//Quick test to make sure the constructor properly fills
//member variables, and that the ToString is working!
//Movie m = new Movie("Star Wars", "Western");
//Console.WriteLine(m);

List<Movie> movies = new List<Movie>();

movies.Add(  new Movie("The Shawshank Redemption", "Drama")  );
movies.Add(new Movie("The Godfather", "Drama"));
movies.Add(new Movie("The Dark Knight", "Superhero"));
movies.Add(new Movie("Return of the King", "Fantasy"));
movies.Add(new Movie("Fellowship of the Ring", "Fantasy"));
movies.Add(new Movie("Empire Strikes Back", "SciFi"));
movies.Add(new Movie("Interstellar", "SciFi"));
movies.Add(new Movie("Superman", "Superhero"));

//Test again! This time test that the list got created and populated correctly.
//foreach(Movie next in movies)
//{
//    Console.WriteLine(next);
//}

Console.WriteLine("Welcome to the Movie Database!");

Console.WriteLine($"There are {movies.Count} movies in this list");

Console.WriteLine("Here are the categories:");
List<string> categories = new List<string>();
foreach (Movie next in movies)
{
	if (categories.IndexOf(next.Category) == -1)
    {
		categories.Add(next.Category);
    }
}

//Found the categories. Let's do another loop to print them out.

foreach (string category in categories)
{
    Console.WriteLine(category);
}

Console.WriteLine();

do
{
	Console.Write("What category are you interested in? ");
	string entry = Console.ReadLine();
	// Look at how to "reverse" a logical operation if you want.
	// e.g.   a == 10 && b == 20 && c != 30
	// Reverse is a != 10 || b != 20 || c ==30

	if (entry == "Drama" || entry == "Superhero" || entry == "Fantasy" || entry == "SciFi")
	{
		foreach (Movie next in movies)
		{
			if (next.Category == entry)
			{
				Console.WriteLine(next);
			}
		}
	}
	else
	{
		Console.WriteLine("Sorry, we do not have that category here.");
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