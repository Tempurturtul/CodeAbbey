using System;

public class MaxOfArray
{
	private static void Main()
	{
        string[] input = Console.ReadLine().Split(' ');
        int max = int.Parse(input[0]);
        int min = int.Parse(input[0]);

        for (int i = 1; i < input.Length; i++)
        {
            if (int.Parse(input[i]) > max)
            {
                max = int.Parse(input[i]);
            }

            if (int.Parse(input[i]) < min)
            {
                min = int.Parse(input[i]);
            }
        }

        Console.WriteLine(max.ToString() + " " + min.ToString());
	}
}
