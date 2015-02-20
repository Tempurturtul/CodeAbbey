using System;

public class MinOfTwo
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < numOfCases; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            if (int.Parse(input[0]) < int.Parse(input[1]))
            {
                answer += input[0] + " ";
            }
            else
            {
                answer += input[1] + " ";
            }
        }

        Console.WriteLine(answer);
	}
}
