Console.WriteLine("Welcome to the Circle Calculator");
Console.WriteLine("--------------------------------");
int counter = 0;
do
{
    
    bool confirm = false;
    while (confirm == false)
    {
        Console.Write("Enter your circle radius: ");
        string entry = Console.ReadLine();
        double RadiusEntry;
        bool validNum = double.TryParse(entry, out RadiusEntry);

        if (validNum && RadiusEntry > 0)
        {
            confirm = true;
            Circle newCircle = new Circle(RadiusEntry);
            Console.WriteLine(newCircle);
            counter++;
        }
        else
        {
            Console.WriteLine("Sorry that is not a valid entry! Please enter a number great than zero.");
            confirm = false;
        }
    }
} while (KeepGoing());
Console.WriteLine($"Goodbye! You created {counter} Circle Objects");

static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.Write("Continue? (y/n): ");
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

public class Circle
{
  
    public double radius;
    public double circumference;
    public double area;

    public Circle(double _radius)
    {
        radius = _radius;
        circumference = CalculateCircumference(_radius);
        area = CalculateArea(_radius);
    }

    public double CalculateCircumference(double _radius)
    {
        circumference = 2 * Math.PI * _radius;
        return circumference;
    }

    public double CalculateArea(double _radius)
    {
        
        area = Math.PI * (_radius * _radius);
        return area;
    }

    public override string ToString()
    {
        return $"Circumference: {Math.Round (circumference,2)}    Area: {Math.Round (area,2)}";
    }

}