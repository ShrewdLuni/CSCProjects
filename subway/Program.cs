using System;

public class Program
{
	public static void Main()
	{
		Calculate(5000);
        Console.WriteLine(Calculate(5000));
	}

	public static string Calculate(double coins = 0)
    {
		double counter = 0;
		double boxes = 0;
		double low = 0;
		double mid = 0;
		string output = null;
		while (coins >= 500)
		{
			boxes = (coins - (coins % 500)) / 500;
			low = boxes * 0.7189 * 300;
			mid = boxes * 0.041 * 1500;
			coins = low + mid;
			coins -= coins % 500;
			output += ("#" + ++counter + " " + coins + "\n");
		}
		return output;
	}
}
