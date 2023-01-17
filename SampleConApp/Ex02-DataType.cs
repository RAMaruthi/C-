using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Ex02_DataType
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The minvalue as{byte.MinValue} and {byte.MaxValue}");
            Console.WriteLine($"The minvalue os{int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The minvalue os{long.MinValue} and {long.MaxValue}");

            int i = 123;
            long l = i;
            i = Convert.ToInt32(l);
            Console.WriteLine(i);
            Console.WriteLine(l);
        }
    }
}
