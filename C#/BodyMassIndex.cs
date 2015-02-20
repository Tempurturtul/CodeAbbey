using System;

public class BodyMassIndex
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";

        for (int i = 0; i < numOfCases; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            float weight = float.Parse(input[0]);
            float height = float.Parse(input[1]);
            float bmi = weight / (float)Math.Pow(height, 2f);

            if (bmi < 18.5f)
            {
                answer += "under ";
            }
            else if (bmi < 25f)
            {
                answer += "normal ";
            }
            else if (bmi < 30f)
            {
                answer += "over ";
            }
            else
            {
                answer += "obese ";
            }
        }

        Console.WriteLine(answer);
	}
}
