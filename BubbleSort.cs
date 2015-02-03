using System;

public class BubbleSort
{
	private static void Main()
	{
        int arrSize = int.Parse(Console.ReadLine());
        string[] arr = Console.ReadLine().Split(' ');
        int passes = 0;
        int swaps = 0;
        bool check = true;

        while (check)
        {
            check = false;

            for (int i = 0; i < arrSize - 1; i++)
            {
                int val1 = int.Parse(arr[i]);
                int val2 = int.Parse(arr[i + 1]);

                if (val1 > val2)
                {
                    arr[i] = val2.ToString();
                    arr[i + 1] = val1.ToString();
                    swaps += 1;
                    check = true;
                }
            }

            passes += 1;
        }

        Console.WriteLine(passes.ToString() + " " + swaps.ToString());
	}
}
