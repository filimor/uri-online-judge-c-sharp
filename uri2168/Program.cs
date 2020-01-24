using System;

namespace uri2168 // Crepúsculo em Portland
{
    internal static class Program
    {
        private static void Main()
        {
            int.TryParse(Console.ReadLine(), out int n);
            int[,] cameras = new int[n + 1, n + 1];

            for (int i = 0; i <= n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                for (int j = 0; j <= n; j++)
                {
                    int.TryParse(str[j], out cameras[i, j]);
                }
            }

            for (int k = 0; k < n; k++)
            {
                for (int l = 0; l < n; l++)
                {
                    int totalCameras = 0;
                    if (cameras[k, l] == 1)
                    {
                        totalCameras++;
                    }
                    if (cameras[k + 1, l] == 1)
                    {
                        totalCameras++;
                    }
                    if (cameras[k, l + 1] == 1)
                    {
                        totalCameras++;
                    }
                    if (cameras[k + 1, l + 1] == 1)
                    {
                        totalCameras++;
                    }
                    if (totalCameras >= 2)
                    {
                        Console.Write("S");
                    }
                    else
                    {
                        Console.Write("U");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}