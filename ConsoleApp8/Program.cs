using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            const int m = 5, n = 4;



            int[,] a = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    a[i, j] = r.Next(100);
                    Console.Write(a[i, j] + "\t");

                    
                }
                Console.WriteLine();

            }

            int min = a[0, 0], minI = 0, minj = 0;
            int max = a[0, 0], maxI = 0, maxj = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (min > a[i, j])
                    {
                        min = a[i, j];
                        minI = i;
                        minj = j;
                    }

                    if (max < a[i, j])
                    {
                        max = a[i, j];
                        maxI = i;
                        maxj = j;
                    }
                }
            }
            Console.WriteLine($"a[{minI+1},{minj+1}] = {min}");
            Console.WriteLine($"a[{maxI + 1},{maxj + 1}] = {max}");





        }
    }



}
