using System;

public class VowelCount
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";
        
        for (int i = 0; i < numOfCases; i++)
        {
            string input = Console.ReadLine();
            int vowelCount = 0;
            
            foreach (char c in input)
            {
                string letter = c.ToString();
                if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u" || letter == "y")
                {
                    vowelCount += 1;
                }
            }

            answer += vowelCount.ToString() + " ";
        }

        Console.WriteLine(answer);
	}
}
