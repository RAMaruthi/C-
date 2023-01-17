using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Accoout
    {
        public int AccoutNo { get; set; }
        public string AccoutName { get; set; }
        public int Balance { get; set; } = 5000;
    }

    class SBAccout:Accoout
    {
        public void Credit(int amout) => Balance += amout;

        public void Debit(int amout) => Balance -= amout;
    }

 
    class Intertaince
    {
        static void Main(string[] args)
        {
            SBAccout acc = new SBAccout { AccoutName = "MAri", AccoutNo = 123 };

            Console.WriteLine($"{acc. Balance}");
            acc.Credit(2000);
            Console.WriteLine($"{ acc.Balance}");
            acc.Debit(3000);
            Console.WriteLine($"{ acc.Balance}");
        }
    }
}
