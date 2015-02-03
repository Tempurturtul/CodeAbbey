using System;

public class SumLoop
{
    public static void Main()
    {
        int pairsToSum = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < pairsToSum; i++)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            answer += (int.Parse(numbers[0]) + int.Parse(numbers[1])).ToString() + " ";
        }

        Console.WriteLine(answer);
    }
}
