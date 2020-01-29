using System;

namespace uri1743
{
    internal static class MaquinaDeVerificacaoAutomatizada
    {
        private static void Main()
        {
            string[] str1 = Console.ReadLine().Split(' ');
            string[] str2 = Console.ReadLine().Split(' ');
            char res = 'Y';
            for (int i = 0; i < 5; i++)
            {
                if (str1[i] == str2[i])
                {
                    res = 'N';
                }
            }
            Console.WriteLine(res);
        }
    }
}