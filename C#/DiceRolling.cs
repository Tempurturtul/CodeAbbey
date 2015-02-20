using System;

public class DiceRolling
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < numOfCases; i++)
        {
            double input = double.Parse(Console.ReadLine());
            int result = (int)Math.Floor(input * 6) + 1;

            answer += result.ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
