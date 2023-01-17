using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Arrays
    {

        static void Main(string[] args)
        {
            //String[] name = new String[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Enter The Name Of Index{i}");
            //    name[i] = Console.ReadLine();
            //}
            //Console.WriteLine(name.Length);
            //Console.WriteLine("The Length Of frist Dimison"+name.GetLength(0));

            //foreach(string nam in name)
            //{
            //    Console.WriteLine(nam);
            //}

            int[,] data = new int[,] { { 1, 2, 3,  }, { 4, 5, 6 }, { 6,7,8} };
            for (int i = 0; i < data.GetLength(0); i++)
            {
                string row = "";
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    row += data[i, j] + "";
                }
                Console.WriteLine(row.TrimEnd());
            }
        }
    }
       
}
