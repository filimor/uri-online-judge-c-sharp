using System;

namespace uri1070 // Seis Números Ímpares
{
	internal static class Program
	{
		private static void Main()
		{
			int.TryParse(Console.ReadLine(), out int x);
			x--;
			if (x % 2 != 0)
			{
				for (int i = 1; i <= 6; i++)
				{
					Console.WriteLine(x += 2);
				}
			}
			else
			{
				x--;
				for (var i = 1; i <= 6; i++)
				{
					Console.WriteLine(x += 2);
				}
			}
		}
	}
}
