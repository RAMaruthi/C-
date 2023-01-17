using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Enums
    {
        enum Week  { Mon, Tue, Wen, Thr, Fri };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the day u like to come to office by selecting any of the possible values below:");
            Array day = Enum.GetValues(typeof(Week));
            for(int i=0;i<day.Length;i++)
                Console.WriteLine(day.GetValue(i));
            object inputVlue = Enum.Parse(typeof(Week), Console.ReadLine(),true);
            Week days = (Week)inputVlue;
            Console.WriteLine(  "The Select Day is"+days);

        }
    }
}
