using System;

public class Program
{
	public static void Main()
    {
		double[] one = { 5, 5, 9, 10 };
		double[] two = { 12, 13, 14, 15, 15 };
		double[] three = { 19, 19, 21, 21 };
		double[] four = { 22, 22, 26 };
		double[][] arr = { one, two, three, four };
        foreach (var list in arr)
        {
            Console.WriteLine("Интервал: " + list.Min() + " - " + list.Max());
            Console.Write("Средняя: ");
			string avg = "(";
			foreach (var item in list)
				avg += item + " + ";
			avg = avg.Remove(avg.Length - 3);
			avg += ") / " + list.Length + " = " + list.Sum() / list.Length;
            Console.Write(avg);
			Console.WriteLine("\nМода: ");
            Console.WriteLine("Медиана: ");

            Console.WriteLine();
        }



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
