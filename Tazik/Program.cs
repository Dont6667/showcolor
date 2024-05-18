using System;

class MainClass
{
    static string ShowColor()
    {
        Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
        var color = Console.ReadLine();

        switch (color)
        {
            case "red":
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
                return "red";

            case "green":
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
                return "green";
            case "cyan":
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
                return "cyan";
            default:
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Your color is yellow!");
                return "yellow";
        }
    }

    public static void Main(string[] args)
    {
        var favcolors = new string[5];
        for (int i = 0; i < favcolors.Length; i++)
        {
            favcolors[i] = ShowColor();
        }
        Console.WriteLine("Your favcolors?:");
        foreach (var color in favcolors)
        {
            Console.WriteLine(color);
        }
        Console.ReadKey();
    }
}