using System;

public class ReverseString
{
	private static void Main()
	{
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length / 2; i++)
        {
            int swapPos = input.Length - (i + 1);

            string letter1 = input[i].ToString();
            string letter2 = input[swapPos].ToString();

            input = input.Remove(i, 1);
            input = input.Insert(i, letter2);
            input = input.Remove(swapPos, 1);
            input = input.Insert(swapPos, letter1);
        }

        Console.WriteLine(input);
	}
}
