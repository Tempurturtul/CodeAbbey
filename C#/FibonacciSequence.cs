using System;
using System.Numerics;

public class FibonacciSequence
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < numOfCases; i++)
        {
            string num = Console.ReadLine();
            string a = "0";
            string b = "1";
            int count = 0;

            while (a != num)
            {
                string result = (BigInteger.Parse(a) + BigInteger.Parse(b)).ToString();
                a = b;
                b = result;
                count++;
            }

            answer += count.ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
