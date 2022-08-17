List<Song> playlist = new List<Song>();

Song song1 = new Song("The Beatles", "I Want to Hold Your Hand", "Rock", 1964);
playlist.Add(song1);

Song song2 = new Song("Pink Floyd", "Comfortable Numb", "Progressive", 1979);
playlist.Add(song2);

Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song3);

foreach(Song next in playlist)
{
    Console.WriteLine(next);   //This prints correctly because the ToString()
}
Console.WriteLine("Here are your songs:");
foreach (Song next in playlist)
{
    Console.WriteLine(next.Title);   //Only prints titles
}

Console.WriteLine();
Console.Write("Which song do you want more details on: ");
string mysong = Console.ReadLine();


class Song
{
    public string Artist;
    public string Title;
    public string Genre;
    public int Year;

    //Constructor
    public Song(string _Artist, string _Title, string _Genre, int _Year)
    {
        Artist = _Artist;
        Title = _Title;
        Genre = _Genre;
        Year = _Year;
    }

    public override string ToString()
    {
        return $"{Title} by {Artist} from {Year} ({Genre})";  //   \"" if you wants quotes
    }

}