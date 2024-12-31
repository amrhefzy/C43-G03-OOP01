using System;

class SeasonEnum
{
    public enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public void PrintSeasonRange()
    {
        Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
        string input = Console.ReadLine();

        if (Enum.TryParse(input, true, out Season season))
        {
            switch (season)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid season input.");
        }
    }
}
