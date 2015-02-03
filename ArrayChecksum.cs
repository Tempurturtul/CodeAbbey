using System;

public class ArrayChecksum
{
	private static void Main()
	{
        int arrayLength = int.Parse(Console.ReadLine());
        string[] array = Console.ReadLine().Split(' ');
        long seed = 113;
        long limit = 10000007;
        long result = 0;

        for (int i = 0; i < arrayLength; i++)
        {
            long val = long.Parse(array[i]);

            result = (result + val) * seed;

            if (result >= limit)
            {
                result = result % limit;
            }
        }

        Console.WriteLine(result.ToString());
	}
}
