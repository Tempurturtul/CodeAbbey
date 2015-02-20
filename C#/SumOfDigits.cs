using System;

public class SumOfDigits
{
	private static void Main()
	{
        int numOfValues = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < numOfValues; i++)
        {
            int returnValue = 0;
            string[] values = Console.ReadLine().Split(' ');
            int val1 = int.Parse(values[0]);
            int val2 = int.Parse(values[1]);
            int val3 = int.Parse(values[2]);

            string result = (val1 * val2 + val3).ToString();

            foreach (char c in result)
            {
                returnValue += (int)Char.GetNumericValue(c);
            }

            answer += returnValue.ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
