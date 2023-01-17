using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class CaseInverse
    {
        public class Exercise15
        {
            public static void Main()
            {
                string str1 = "";
                char[] arr1;
                int length = 0;
                char ch;
                Console.WriteLine("Input the string : ");
                str1 = Console.ReadLine();
                length = str1.Length;
                arr1 = str1.ToCharArray(0, length);
                Console.WriteLine("After conversion, the string is : ");
                for (int i = 0; i < length; i++)
                {
                    ch = arr1[i];
                    if (Char.IsLower(ch))
                        Console.Write(Char.ToUpper(ch));
                    else
                        Console.Write(Char.ToLower(ch));
                }
                Console.WriteLine();
            }
        }
    }
}
