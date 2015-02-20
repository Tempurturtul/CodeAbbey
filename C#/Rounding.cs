using System;

public class Rounding
{
	private static void Main()
	{
        int pairsToRound = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < pairsToRound; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            float val1 = float.Parse(input[0]);
            float val2 = float.Parse(input[1]);

            if (val1 % val2 == 5)
            {
                answer += Math.Ceiling(val1 / val2).ToString() + " ";
            }
            else
            {
                answer += Math.Round(val1 / val2).ToString() + " ";
            }

        }

        Console.WriteLine(answer);
	}
}
