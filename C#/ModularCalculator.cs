using System;
using System.Numerics;

public class ModularCalculator
{
	private static void Main()
	{
        string value = Console.ReadLine();
        string[] operation = Console.ReadLine().Split(' ');

        while (operation[0] != "%")
        {
            if (operation[0] == "+")
            {
                value = (BigInteger.Parse(value) + int.Parse(operation[1])).ToString();
            }
            else
            {
                value = (BigInteger.Parse(value) * int.Parse(operation[1])).ToString();
            }

            operation = Console.ReadLine().Split(' ');
        }

        string answer = (BigInteger.Parse(value) % int.Parse(operation[1])).ToString();
        Console.WriteLine(answer);
	}
}
