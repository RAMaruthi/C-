using System;
namespace SampleConApp
{
    class Ex01
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Name");
            string name= Console.ReadLine();
            Console.WriteLine(" ENTER THE ADDRESS");
             string add=Console.ReadLine();
            Console.WriteLine("Enter the salary");
            double salary =int.Parse( Console.ReadLine());

            Console.WriteLine($"The name {name} from {add} Earing salary of Rs.{salary}");

        }

    }
}