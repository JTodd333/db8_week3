//GoogleDoc to go with this

Triangle first = new Triangle(4, 3); //added in 4,3 here to replace the next 2 lines
//first.Length = 4;    Not needed now with constructor
//first.Height = 3;

Console.WriteLine(first.GetArea());
Console.WriteLine(first.GetHypotenuse());
Console.WriteLine(first.GetPerimeter());

//first.Height = 10;  (Won't work since Height is private below)

class Triangle
{
    //We have a package, like a capsule
    //The verb we use is "encapsulate"
    //We've packaged together Length and Height
    //into a triangle concept.
    //We have "encapsulated" Length and Height
    //into a triangle

    private double Length; //private makes it so that this value cannot be changed
    private double Height;
    private double Area;

    //Initializing the data
    //Create a constuctor
    public Triangle(double _length, double _height)
    {
        Length = _length;
        Height = _height;
        Area = Length * Height / 2;

        //Area = _length * _height / 2;  (This was done before set to private)
    }   //(We dont want to do this, only called once so changing height/length would get the same area

    public double GetArea()
    {
        return Area;
    }

    public double GetHypotenuse()
    {
        return Math.Sqrt(Length * Length + Height * Height);
    }

    public double GetPerimeter()
    {
        return Length + Height + GetHypotenuse();
    }
}