/*      Create a program, which calculates the volume of n beer kegs. You will receive in total 3 * n lines. Every three lines will hold information for a single keg. First up is 
the model of the keg, after that is the radius of the keg, and lastly is the height of the keg.

Calculate the volume using the following formula: π * r^2 * h.

In the end, print the model of the biggest keg.

Input
You will receive 3 * n lines. Each group of lines will be on a new line:
· First – model – string
· Second –radius – floating-point number
· Third – height – integer number

Output
Print the model of the biggest keg.

Constraints
· n will be in the interval [1…10].
· The radius will be a floating-point number in the interval [1…3.402823E+38].
· The height will be an integer in the interval [1…2147483647].                                             */


int kegCount = int.Parse(Console.ReadLine());

string maxModel = "";
decimal maxVolume = decimal.MinValue;

for (int i = 0; i < kegCount; i++)
{
    string model = Console.ReadLine();
    decimal radius = decimal.Parse(Console.ReadLine());
    int height = int.Parse(Console.ReadLine());

    decimal volume = (decimal)Math.PI * radius * radius * height;

    if (volume > maxVolume)
    {
        maxVolume = volume;
        maxModel = model;
    }
}
Console.WriteLine(maxModel);