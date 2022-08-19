Console.WriteLine("Welcome to Sift, what would you like to do?");
bool keepgoing = true;

do
{
    Console.WriteLine("1. Add a Team Member");
    Console.WriteLine("2. Search For a Team Member");
    Console.WriteLine("3. Print All Members");
    Console.WriteLine("4. Quit");
    Console.Write("Select an Option: ");
    string entry = Console.ReadLine();
    int option = int.Parse(entry);

    List<SiftMember> members = new List<SiftMember>();
    members.Add(new SiftMember("Amy Andrews", new DateTime(2022, 1, 1), "Purchase Closing Specialist", "aandrews@rm.com"));
    members.Add(new SiftMember("Bailey Bennet", new DateTime(2019, 5, 13), "Mortgage Banker", "bbennett@rm.com"));

    if (option == 1)
    {
        Console.Write("Enter the name of the team member: ");
        string newName = Console.ReadLine();
        Console.Write("Enter Start Date: ");
        string starEntry = Console.ReadLine();
        var newDate = DateTime.TryParse(starEntry, out DateTime newAnniversary);
        newAnniversary = newAnniversary.Date;

        Console.Write("Enter Job Title: ");
        string newTitle = Console.ReadLine();
        Console.Write("Enter Email: ");
        string newEmail = Console.ReadLine();

        members.Add(new SiftMember(newName, newAnniversary, newTitle, newEmail));
        Console.WriteLine("Added: ");
        Console.WriteLine(members.Last());

    }


    if (option == 2)
    {
        Console.Write("Enter the full name of the person you'd like to search for: ");
        string nameentry = Console.ReadLine();

        SiftMember found = FindMember(members, nameentry);
        if (found == null)
        {
            Console.WriteLine("Sorry, we dont have that team member.");
        }
        else
        {
            Console.WriteLine(found);
        }


    }


    if (option == 3)
    {
        foreach (SiftMember member in members)
        {
            Console.WriteLine(member);
        }
    }

    if (option == 4)
    {
        Console.WriteLine("Goodbye!");
        keepgoing = false;
    }


    static SiftMember FindMember(List<SiftMember> members, string _name)
    {
        foreach (SiftMember next in members)
        {
            if (next.name.ToLower() == _name.ToLower())
            {
                return next;
            }
        }
        return null;
    }
} while (keepgoing == true);




public class SiftMember
{
    public string name;
    public DateTime anniversay;
    public string jobTitle;
    public string email;

   
    public List<string> skills = new List<string>();

    public SiftMember(string _name, DateTime _anniversary, string _jobTitle, string _email ) //List<string> _skills
    {
        name = _name;
        anniversay = _anniversary;
        jobTitle = _jobTitle;
        email = _email;
        //skills = _skills;
    }


    

    public override string ToString()
    {
        return $"  Name: {name} \n  Job Title: {jobTitle} \n  Anniversary: {anniversay} \n  Email: {email} \n"; //\n Skills: 
    }  

}