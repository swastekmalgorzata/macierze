using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace macierze
{
    class Program
    {
        static void Main(string[] args)
        {
            const int n=3, m=3, k=2;
            int[,] macA = new int[n, k];
            int[,] macB = new int[k, m];
            int[,] macC = new int[n, m];
            for(int i = 0; i<n;i++)
            {
                for(int j = 0; j<k;j++)
                {
                    Console.WriteLine("podaj A[{0},{1}]",i+1, j+1);
                    macA[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < k; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine("podaj B[{0},{1}]", i + 1, j + 1);
                    macB[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    for (int x = 0; x <k; x++)
                    {
                        macC[i, j] += macA[i, x] * macB[x, j];
                    }                    
                }
            }
            foreach (int x in macC)
            {
                Console.WriteLine("Macierz C; {0}", x);
            }

            Console.ReadKey();





        }
    }
}
