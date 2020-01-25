using System;

namespace uri1573 // Fábrica de Chocolate
{
	internal static class Program
	{
		private static void Main()
		{
			string[] str = Console.ReadLine().Split(' ');
			int.TryParse(str[0], out int a);
			int.TryParse(str[1], out int b);
			int.TryParse(str[2], out int c);
			while (a != 0 && b != 0 && c != 0)
			{
				Console.WriteLine(Math.Floor(Math.Pow(a * b * c, 1.0 / 3.0)).ToString("F0"));
				str = Console.ReadLine().Split(' ');
				int.TryParse(str[0], out a);
				int.TryParse(str[1], out b);
				int.TryParse(str[2], out c);
			}
		}
	}
}