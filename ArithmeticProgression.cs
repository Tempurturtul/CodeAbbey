using System;

public class ArithmeticProgression
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";
	
        for (int num = 0; num < numOfCases; num++)
        {
            string[] vals = Console.ReadLine().Split(' ');
            int a = int.Parse(vals[0]);
            int b = int.Parse(vals[1]);
            int n = int.Parse(vals[2]);
            int result = a;

            for (int i = 1; i < n; i++)
            {
                result += a + i * b;
            }

            answer += result.ToString() + " ";
        }

        Console.WriteLine(answer);
    }
}
