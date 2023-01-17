using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    interface Example
    {
        void Create();
    }
    interface Example1
    {
        void Create();
    }
    class Multipaleinterface : Example, Example1
    {
        public void Create()
        {
            Console.WriteLine("General Implemention");
        }

        void Example.Create() => Console.WriteLine("Simple version of Create");
        void Example1.Create() => Console.WriteLine("Example version of Create");
    }

    class Multipaleinterface1
    {
        static void Main(string[] args)
        {
            Multipaleinterface e = new Multipaleinterface();
            e.Create();
            Example1 b = new Multipaleinterface();
            b.Create();

            Example a = new Multipaleinterface();
            a.Create();

         


        }
    }
}
