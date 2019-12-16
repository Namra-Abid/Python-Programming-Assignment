using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication102
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            for (int i = 0; i < n.Length; i++)
            {
                Console.Write(n[i] + " ");
            }
            int temp;
            int minimum;
            for (int i = 0; i < n.Length - 1; i++)
            {
                minimum = i;


                for (int j = i + 1; j < n.Length; j++)
                {
                    if (n[j] < n[minimum])
                        minimum = j;
                }
                temp = n[minimum];
                n[minimum] = n[i];
                n[i] = temp;

            }
            for (int i = 0; i < n.Length; i++)
            {
                Console.WriteLine();
                Console.Write(n[i]);

            }
        }
    }
}
