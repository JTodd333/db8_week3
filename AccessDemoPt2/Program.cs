
Car first = new Car("Chevy", "Trax", Color.Blue);

//Console.WriteLine(first.Color); //prints blue
//Console.WriteLine(first.Make);  //Cant access it because private
// first.Make = "Ford";  //We cannnot write the value of make
Console.WriteLine(first.GetMake()); //this works because the function is public
Console.WriteLine(first.GetModel());
Console.WriteLine(first.GetColor());
first.SetColor(Color.Red);  
Console.WriteLine(first.GetColor());
//first.SetColor("White");
Console.WriteLine(first.GetColor());


// bool yesno = false;  //Two possible choices for boolean variable.
//int n = 100;   //int a lot of choices
//double p = 3.14;  // a lot of choices as well.
//Color carcolor = Color.Blue;  //Only 4 possible choices because of the enum.

//Example of enumerator, added later, works without this.
//Color carcolor = Color.Red;

Color pianocolor = Color.Black; //We have 4 possible choices: Red, Blue, Black, Silver
pianocolor = Color.Red;

enum Color
{
    Red,
    Blue,
    Black,
    Silver
}



class Car
{
    // Attributes that cannot be changed
    private string Make;
    private string Model;

    //Cant be changed
    private Color CarColor;

    //Constructor
    public Car(string _make, string _model, Color _color)
    {
        Make = _make;
        Model = _model;
        CarColor = _color;
    }
    //Make only has a "getter" method, so we can only look at it. We cannot change it.
    public string GetMake()
    {
        return Make;
    }
    //Model only has a "getter" method, so we can only look at it. We cannot change it.
    public string GetModel()
    {
        return Model;
    }

    // Color has both a "getter" and "setter" so we can lok at it AND change it.
    public Color GetColor()
    {
        return CarColor;
    }

    public void SetColor(Color _color)
    {
        ////Let's do some validation. Make sure it's a valid color.
        //if (_color == Color.Red || _color == Color.Blue || _color == Color.Black || _color == Color.Silver)
        //{
        //    CarColor = _color;
        //}
        //With an enum, we dont need to validate
        CarColor = _color;
    }
}