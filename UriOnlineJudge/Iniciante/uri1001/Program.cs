using System;

namespace uri1001 // Extremamente Básico
{
	internal static class Program
	{
		private static void Main()
		{
			int.TryParse(Console.ReadLine(), out int a);
			int.TryParse(Console.ReadLine(), out int b);
			Console.WriteLine($"X = {a + b}");
		}
	}
}