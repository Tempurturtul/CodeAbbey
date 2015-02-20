using System;
using System.Numerics;

public class ModuloTimeDifference
{
	private static void Main()
	{
        int numOfCases = int.Parse(Console.ReadLine());
        string answer = "";

        for(int i = 0; i < numOfCases; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            string date1Seconds = (int.Parse(input[0]) * 60 * 60 * 24 + int.Parse(input[1]) * 60 * 60 + int.Parse(input[2]) * 60 + int.Parse(input[3])).ToString();
            string date2Seconds = (int.Parse(input[4]) * 60 * 60 * 24 + int.Parse(input[5]) * 60 * 60 + int.Parse(input[6]) * 60 + int.Parse(input[7])).ToString();
            string difference = (BigInteger.Parse(date2Seconds) - BigInteger.Parse(date1Seconds)).ToString();
            
            string remainingSeconds = difference;
            string differenceDays = (BigInteger.Parse(remainingSeconds) / 86400).ToString();
            remainingSeconds = (BigInteger.Parse(remainingSeconds) % 86400).ToString();
            string differenceHours = (BigInteger.Parse(remainingSeconds) / 3600).ToString();
            remainingSeconds = (BigInteger.Parse(remainingSeconds) % 3600).ToString();
            string differenceMinutes = (BigInteger.Parse(remainingSeconds) / 60).ToString();
            remainingSeconds = (BigInteger.Parse(remainingSeconds) % 60).ToString();
            string differenceSeconds = remainingSeconds;

            answer += string.Format("({0} {1} {2} {3}) ", differenceDays, differenceHours, differenceMinutes, differenceSeconds);
        }

        Console.WriteLine(answer);
	}
}