using System;

public class WeightedSumOfDigits
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string[] cases = Console.ReadLine().Split(' ');
        string answer = "";

        for (int i = 0; i < numOfCases; i++)
        {
            string value = cases[i];
            int position = 0;
            int result = 0;

            foreach (char c in value)
            {
                position += 1;
                result += (int)Char.GetNumericValue(c) * position;
            }

            answer += result.ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
