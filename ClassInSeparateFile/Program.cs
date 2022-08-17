// Below line is needed to access Rectangle.
// Matches namespace name of the other file.
using ClassInSeparateFile;

Console.WriteLine(Rectangle.Count);

Rectangle rect = new Rectangle("First", 10.1, 20.2);
Console.WriteLine(rect);
Console.WriteLine(Rectangle.Count);

Rectangle rect2 = new Rectangle("Second", 2.5, 3.6);
Console.WriteLine(rect2);
Console.WriteLine(Rectangle.Count);

Rectangle rect3 = new Rectangle("Third", 1.1, 2.2);
Console.WriteLine(rect3);
Console.WriteLine(Rectangle.Count);

string entry = "10";
Console.WriteLine(int.Parse(entry));  







//examples of decimals vs doubles. Doubles not as accurate.
//double x = 10.1;
//double y = 20.2;
//double z = x * y;
//Console.WriteLine(z);

//decimal a = 10.1m;
//decimal b = 20.2m;
//decimal c = a * b;
//Console.WriteLine(c);