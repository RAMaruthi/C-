using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Base
    {
        public void basefnc() => Console.WriteLine("The call base func");
    }

    class Derivedclass:Base
    {
        public void Derivedfuc() => Console.WriteLine("The Dveried Class is calling");
        public void basefnc() => Console.WriteLine("The call  func");

    }
    class Methodhiding
    {
        static void Main(string[] args)
        {
            Base b = new Derivedclass();
            b.basefnc();
            b.basefnc();
            
        }
    }
}
