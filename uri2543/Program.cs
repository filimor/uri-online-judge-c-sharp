using System;

namespace uri2543 // Jogatina UFPR
{
	internal static class Program
	{
		private static void Main()
		{
			string str;

			while (!string.IsNullOrEmpty(str = Console.ReadLine()))
			{
				string[] linha = str.Split(' ');
				int.TryParse(linha[0], out int n);
				int.TryParse(linha[1], out int id);
				int total = 0;

				for (int x = 0; x < n; x++)
				{
					string[] caso = Console.ReadLine().Split(' ');
					if (caso[0] == id.ToString() && caso[1] == "0")
					{
						total++;
					}
				}

				Console.WriteLine(total);
			}
		}
	}
}