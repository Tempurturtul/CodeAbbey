using System;

public class MedianOfThree
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < numOfCases; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int val1 = int.Parse(input[0]);
            int val2 = int.Parse(input[1]);
            int val3 = int.Parse(input[2]);

            if ((val1 < val2 && val1 > val3) || (val1 > val2 && val1 < val3))
            {
                answer += val1.ToString() + " ";
            }
            else if ((val2 < val1 && val2 > val3) || (val2 > val1 && val2 < val3))
            {
                answer += val2.ToString() + " ";
            }
            else
            {
                answer += val3.ToString() + " ";
            }
        }

        Console.WriteLine(answer);
	}
}
