using System;

namespace uri1079 // Médias Ponderadas
{
	internal static class Program
	{
		private static void Main()
		{
			int.TryParse(Console.ReadLine(), out int n);
			for (int i = 1; i <= n; i++)
			{
				string[] entrada = Console.ReadLine().Split(' ');
				double.TryParse(entrada[0], out double a);
				double.TryParse(entrada[1], out double b);
				double.TryParse(entrada[2], out double c);
				Console.WriteLine((((a * 2.0) + (b * 3.0) + (c * 5.0)) / 10.0).ToString("F1"));
			}
		}
	}
}
