using System;

namespace uri2582 // System of a Download
{
	internal static class Program
	{
		private static void Main()
		{
			int.TryParse(Console.ReadLine(), out int c);
			for (int i = 0; i < c; i++)
			{
				string[] str = Console.ReadLine().Split(' ');
				int.TryParse(str[0], out int x);
				int.TryParse(str[1], out int y);

				switch (x + y)
				{
					case 0:
						Console.WriteLine("PROXYCITY");
						break;
					case 1:
						Console.WriteLine("P.Y.N.G.");
						break;
					case 2:
						Console.WriteLine("DNSUEY!");
						break;
					case 3:
						Console.WriteLine("SERVERS");
						break;
					case 4:
						Console.WriteLine("HOST!");
						break;
					case 5:
						Console.WriteLine("CRIPTONIZE");
						break;
					case 6:
						Console.WriteLine("OFFLINE DAY");
						break;
					case 7:
						Console.WriteLine("SALT");
						break;
					case 8:
						Console.WriteLine("ANSWER!");
						break;
					case 9:
						Console.WriteLine("RAR?");
						break;
					case 10:
						Console.WriteLine("WIFI ANTENNAS");
						break;
				}
			}
		}
	}
}