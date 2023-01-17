using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Transver
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[,] n = { { 1, 2 }, { 4, 5 } };
            // Console.WriteLine(n[0,0]); Console.WriteLine(n[1, 0]);
            //Console.WriteLine(n[0, 1]); Console.WriteLine(n[1, 1]);
            for (int i = 0; i < n.GetLength(0); i++)
            {
                Console.Write("Row " + i + ": ");

                for (int j = 0; j < n.GetLength(1); j++)
                {
                    sum += n[i, j];
                    Console.Write(n[i,j] + " ");
                }
                Console.WriteLine(sum);
            }
        }
    }
}
