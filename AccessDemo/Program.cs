
Car first = new Car("Chevy", "Trax", "Blue");

//Console.WriteLine(first.Color); //prints blue
//Console.WriteLine(first.Make);  //Cant access it because private
// first.Make = "Ford";  //We cannnot write the value of make
Console.WriteLine(first.GetMake()); //this works because the function is public
Console.WriteLine(first.GetModel());
Console.WriteLine(first.Color);
first.Color = "Red";   //public, can be changed
Console.WriteLine(first.Color);

class Car
{
    // Attributes that cannot be changed
    private string Make;
    private string Model;

    // Attributes that can be changed
    public string Color;

    //Constructor
    public Car(string _make, string _model, string _color)
    {
        Make = _make;
        Model = _model;
        Color = _color;
    }

    public string GetMake()
    {
        return Make;
    }
    public string GetModel()
    {
        return Model;
    }

}