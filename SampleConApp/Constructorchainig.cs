using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Base
    {

        public Base()
        {
            Console.WriteLine(  "Base Calss");
            }
        public Base(int a):this()
        {
            Console.WriteLine("The Base Cons Overloade");
        }
    }
    class Diverd : Base
    {
        public Diverd():base(123)
        {
            Console.WriteLine("The Diverd");
        }
    }
    class Constructorchainig
    {
        static void Main(string[] args)
        {

            Diverd c = new Diverd();
            
        }

    }
}
