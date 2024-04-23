using System;

public class Program
{
	public static void Main()
	{
		double coins = Convert.ToInt64(Console.ReadLine());
		double counter = 0;
		double boxes = 0;
		double low = 0;
		double mid = 0;
        while (coins >= 500)
        {
			boxes = (coins - (coins % 500)) / 500;
			low = boxes * 0.7189 * 300;
			mid = boxes * 0.041 * 1500;
			coins = low + mid;
			coins -= coins % 500;
			Console.WriteLine("#" + ++counter + " " + coins);
        }
	}
}
