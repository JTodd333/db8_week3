//Exercise 42
Console.Write("Enter a X Coodinate: ");
string entry1 = Console.ReadLine();
double entryX = Convert.ToDouble(entry1);

Console.Write("Enter a Y Coordinate: ");
string entry2 = Console.ReadLine();
double entryY = Convert.ToDouble(entry2);

Point newPoint = new Point(entryX, entryY);
Console.WriteLine(newPoint.Distance(entryX, entryY));
Console.WriteLine(newPoint);



public class Point
{
    public double x;
    public double y;
    public double answer;

    public Point()
    {

    }

    public Point(double _x, double _y)
    {
        x = _x;
        y = _y;
    }

    public double Distance(double x, double y)
    {
        answer = Math.Sqrt((x * x) + (y * y));
        return answer;
    }

    public override string ToString()
    {
        return $"You have created a point object ({x},{y}). It has a distance of {answer}.";
    }
}