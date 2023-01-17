using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class ass3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter the cts equilavent name for the type");
            string typeName = Console.ReadLine();
            Type type = Type.GetType(typeName, true, true);
            Array myArray = Array.CreateInstance(type, size);
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Enter the value of typr{type.Name}");
                string entervalue = Console.ReadLine();
                object co = Convert.ChangeType(entervalue, type);
                myArray.SetValue(co, i);
            }

            Console.WriteLine("All the Values are set");
            foreach (object item in myArray)
            {
                Console.WriteLine(item);
            }

      
        }

    }
}
