using System;

public class FahrenheitToCelsius
{
    private static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int numToConvert = int.Parse(input[0]);
        string answer = "";

        for (int i = 1; i <= numToConvert; i++)
        {
            answer += ConvertF(int.Parse(input[i])).ToString() + " ";
        }

        Console.WriteLine(answer);
    }

    private static int ConvertF(int fahrenheitVal)
    {
        float celsiusVal = (fahrenheitVal - 32) * (5f / 9f);
        return (int)Math.Round(celsiusVal);
    }
}
