using System;

namespace uri1379 // Problema com Mediana e Média
{
	internal static class Program
	{
		private static void Main()
		{
			string[] str = Console.ReadLine().Split(' ');
			int.TryParse(str[0], out int a);
			int.TryParse(str[1], out int b);
			int mediana;

			while (a != 0 && b != 0)
			{
				int menor = Math.Min(a, b);
				int maior = Math.Max(a, b);
				for (int c = menor - maior; c <= int.MaxValue; c++)
				{
					int media = (a + b + c) / 3;

					if (b >= a && a >= c)
					{
						mediana = a;
					}
					else if (a >= b && b >= c)
					{
						mediana = b;
					}
					else
					{
						mediana = c;
					}

					if (mediana == media)
					{
						Console.WriteLine(c);
						break;
					}
				}

				str = Console.ReadLine().Split(' ');
				int.TryParse(str[0], out a);
				int.TryParse(str[1], out b);
			}
		}
	}
}