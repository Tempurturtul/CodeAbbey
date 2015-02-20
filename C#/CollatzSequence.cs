using System;

public class CollatzSequence
{
	private static void Main()
	{
        int numOfValues = int.Parse(Console.ReadLine());
        string[] values = Console.ReadLine().Split(' ');
        string answer = "";

        for (int i = 0; i < numOfValues; i++)
        {
            int result = int.Parse(values[i]);
            int count = 0;

            while (result != 1)
            {
                count++;

                if (result % 2 == 0)
                {
                    result /= 2;
                }
                else
                {
                    result = 3 * result + 1;
                }
            }

            answer += count.ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
