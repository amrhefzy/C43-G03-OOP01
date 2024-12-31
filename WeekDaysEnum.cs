using System;

class WeekDaysEnum
{
    public enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public void PrintWeekDays()
    {
        Console.WriteLine("Days of the Week:");
        foreach (var day in Enum.GetNames(typeof(WeekDays)))
        {
            Console.WriteLine(day);
        }
    }
}
