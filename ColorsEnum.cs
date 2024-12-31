using System;

class ColorsEnum
{
    public enum Colors
    {
        Red,
        Green,
        Blue
    }

    public void CheckColor()
    {
        Console.WriteLine("Enter a color name (Red, Green, Blue):");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Colors color))
        {
            Console.WriteLine($"{color} is a primary color.");
        }
        else
        {
            Console.WriteLine($"{input} is not a primary color.");
        }
    }
}
