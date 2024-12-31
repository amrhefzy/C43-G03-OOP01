using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Select an option:");
        Console.WriteLine("1 - Print Week Days");
        Console.WriteLine("2 - Print Season Month Range");
        Console.WriteLine("3 - Manage Permissions");
        Console.WriteLine("4 - Check Primary Color");
        Console.Write("Enter your choice: ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                var weekDaysEnum = new WeekDaysEnum();
                weekDaysEnum.PrintWeekDays();
                break;

            case 2:
                var seasonEnum = new SeasonEnum();
                seasonEnum.PrintSeasonRange();
                break;

            case 3:
                var permissionsEnum = new PermissionsEnum();
                permissionsEnum.ManagePermissions();
                break;

            case 4:
                var colorsEnum = new ColorsEnum();
                colorsEnum.CheckColor();
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}
