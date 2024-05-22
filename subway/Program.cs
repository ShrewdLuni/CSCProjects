using System;

public class Program
{
	public static void Main()
    {
		int[] arr = { 9, 8, 123, 0, 0, 1, 2, 3, 5, 6, 4, 1, -1, 13, 16, 11, 170, 90, 80, -2, 4,-99,-98,-97,-1124 };
		foreach(var item in InterSort(arr))
            Console.Write(item + " ");
        Console.WriteLine();
		foreach (var item in BubbleSort(arr))
            Console.Write(item + " ");

		//double[] one = { 5, 5, 9, 10 };
		//double[] two = { 12, 13, 14, 15, 15 };
		//double[] three = { 19, 19, 21, 21 };
		//double[] four = { 22, 22, 26 };
		//double[][] arr = { one, two, three, four };
  //      foreach (var list in arr)
  //      {
  //          Console.WriteLine("Интервал: " + list.Min() + " - " + list.Max());
  //          Console.Write("Средняя: ");
		//	string avg = "(";
		//	foreach (var item in list)
		//		avg += item + " + ";
		//	avg = avg.Remove(avg.Length - 3);
		//	avg += ") / " + list.Length + " = " + list.Sum() / list.Length;
  //          Console.Write(avg);
		//	Console.WriteLine("\nМода: ");
  //          Console.WriteLine("Медиана: ");

  //          Console.WriteLine();
  //      }
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

	public static int[] InterSort(int[] arr)
    {
		int n = arr.Length;
		for (int i = 1; i < n; ++i)
		{
			int key = arr[i];
			int j = i - 1;
			while (j >= 0 && arr[j] > key)
			{
				(arr[j + 1],arr[j]) = (arr[j],arr[j + 1]);
				j = j - 1;
			}
			arr[j + 1] = key;
		}
		return arr;
	}

	public static int[] BubbleSort(int[] arr)
    {
		int n = arr.Length;
		for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i] < arr[j])
					(arr[i], arr[j]) = (arr[j], arr[i]);
			}
        }
		return arr;
    }
}
