using System;

public class AverageOfArray
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";
        
        for (int i = 0; i < numOfCases; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            int sum = 0;
            int amount = 0;
            
            foreach(string s in input)
            {
                if (s != "0")
                {
                    amount += 1;
                    sum += int.Parse(s);
                }
                else
                {
                    break;
                }
            }

            answer += Math.Round((float)sum / (float)amount).ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
