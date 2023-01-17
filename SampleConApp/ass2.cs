using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class ass2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the operation you want to perform as '+' or '-' or '*' or '/'");
            string operation = Console.ReadLine();
            int res = 0;
            switch (operation)
            {

                case "+":
                    Console.WriteLine(res = num1 + num2);
                    break;
                case "-":
                    Console.WriteLine(res = num1 - num2);
                    break;
                case "*":
                    Console.WriteLine(res = num1 * num2);
                    break;
                case "/":
                    Console.WriteLine(res = num1 / num2);
                    break;
                default:
                    Console.WriteLine("Enter the valid operation symbol to be performed");
                    break;
            }

        }
    }
}