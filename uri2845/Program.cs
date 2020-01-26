using System;
using System.Linq;

namespace uri2845 // Festa no Polo Norte
{
	internal static class Program
	{
		private static void Main()
		{
			int.TryParse(Console.ReadLine(), out int n);
			string[] str = Console.ReadLine().Split(' ');
			int[] ids = new int[n];
			//bool coprimos = false;

			for (int i = 0; i < n; i++)
			{
				int.TryParse(str[i], out ids[i]);
			}

			Array.Sort(ids);

			for (int i = ids[ids.GetUpperBound(0)]; i < int.MaxValue; i++)
			{
				foreach (int id in ids)
				{
					//if (
				}
			}
		}
	}
}