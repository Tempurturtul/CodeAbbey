using System;

public class ArrayCounters
{
	private static void Main()
	{
        string[] input0 = Console.ReadLine().Split(' ');
        string[] input1 = Console.ReadLine().Split(' ');
        int m = int.Parse(input0[0]);
        int n = int.Parse(input0[1]);
        int[] results = new int[n];
        string answer = "";

        for (int i = 0; i < m; i++)
        {
            for (int val = 1; val <= n; val++)
            {
                if (int.Parse(input1[i]) == val)
                {
                    results[val - 1] += 1;
                    break;
                }
            }
        }

        foreach(int val in results)
        {
            answer += val.ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
