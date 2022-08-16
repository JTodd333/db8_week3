//first pen is an opject that has inside it four variables
Pen firstpen = new Pen();
firstpen.InkColor = "blue";
firstpen.Length = 4.5;
firstpen.PointType = "Gel";
firstpen.PointSize = "Small";
firstpen.InkAmount = 5;

Console.WriteLine(firstpen.InkColor);
Console.WriteLine(firstpen.Length);
Console.WriteLine(firstpen.PointType);
Console.WriteLine(firstpen.PointSize);
Console.WriteLine(firstpen.InkAmount);

Console.WriteLine("Let's draw with firstpen!");
firstpen.Draw();
Console.WriteLine($"The ink is now {firstpen.InkAmount}");

Console.WriteLine();

Pen secondpen = new Pen();
secondpen.InkColor = "red";
secondpen.Length = 4.5;
secondpen.PointType = "Ball Point";
secondpen.PointSize = "Medium";
secondpen.InkAmount = 2;


Console.WriteLine(secondpen.InkColor);
Console.WriteLine(secondpen.Length);
Console.WriteLine(secondpen.PointType);
Console.WriteLine(secondpen.PointSize);
Console.WriteLine(secondpen.InkAmount);

Console.WriteLine("Let's do two drawings with second pen");
secondpen.Draw();
secondpen.Draw();

Console.WriteLine($"secondpend now has ink level {secondpen.InkAmount}");
Console.WriteLine($"firstpen now has ink level {secondpen.InkAmount}");

secondpen.Draw();
Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}"); //Wont go in neg because if statement

secondpen.Refill();
Console.WriteLine($"secondpen now has ink level {secondpen.InkAmount}");

Console.WriteLine();
Console.WriteLine("Let's refill firstpen with green ink");
firstpen.Refill("green");
Console.WriteLine($"firstpen has ink {firstpen.InkAmount}");

Console.WriteLine();
Pen thirdpen = new Pen();
Console.WriteLine(thirdpen.InkAmount); //defaults to 10 now because Public Pen Method

Console.WriteLine();
Pen fourthpen = new Pen("green");
Console.WriteLine(fourthpen.InkAmount);
Console.WriteLine(fourthpen.InkColor);

class Pen
{
    //Member variables (properties used to be but changed that meaning)
    public string InkColor;
    public double Length;
    public string PointType;
    public string PointSize;
    public int InkAmount;

    public Pen()  //Constructor
    {
        InkAmount = 10;
        InkColor = "black";
    }

    public Pen(string _InkColor)
    {
        InkColor = _InkColor;
        InkAmount = 10;
    }

    //Member Methods
    public void Draw()
    {
        if (InkAmount > 0)
        {
            InkAmount--;
        }
    }

    public void Refill()
    {
        InkAmount = 10;
    }

    //Let's add anothe Refill function that let's us specify ink color.
    public void Refill(string newcolor)
    {
        InkColor = newcolor;
        InkAmount = 10;
    }
}