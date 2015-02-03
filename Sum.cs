using System;

public class Sum
{
    private static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        Console.WriteLine(int.Parse(input[0]) + int.Parse(input[1]));
    }
}