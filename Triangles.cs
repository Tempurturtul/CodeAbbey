using System;

public class Triangles
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < numOfCases; i++)
        {
            string[] sides = Console.ReadLine().Split(' ');
            int sideA = int.Parse(sides[0]);
            int sideB = int.Parse(sides[1]);
            int sideC = int.Parse(sides[2]);
            string result = "0 ";

            if (sideA > sideB && sideA > sideC)
            {
                if (sideB + sideC >= sideA)
                {
                    result = "1 ";
                }
            }
            else if (sideB > sideC)
            {
                if (sideA + sideC >= sideB)
                {
                    result = "1 ";
                }
            }
            else
            {
                if (sideA + sideB >= sideC)
                {
                    result = "1 ";
                }
            }

            answer += result;
        }

        Console.WriteLine(answer);
	}
}
