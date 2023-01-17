using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Example
    {
        internal static int value;
        public Example()
        {
           
        Console.WriteLine("Instance Constructor");
        }

        static Example()
        {
            value = 1000;
            Console.WriteLine("Static Constructor");
        }
    }

    static class Single
    {
        public static void StaticMethod() => Console.WriteLine("Static method called");
    }
    class StaticConstructors
    {
        static void Main(string[] args)
        {
            Example e = new Example();
            Single. StaticMethod();
            Example.value = 1230;
        }
    }
}
