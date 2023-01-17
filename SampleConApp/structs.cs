using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    struct emp
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpAdd { get; set; }
        public double EmpSalry { get; set; }
        
        public string getAll()
        {
            return $"The Name {EmpName}  from {EmpAdd} with Salary {EmpSalry}";
        }
    }
    class structs
    {
        static void Main(string[] args)
        {
            emp e = new emp { EmpId = 123, EmpName = "Maruthi", EmpAdd = "Dvg", EmpSalry = 55555 };
            Console.WriteLine(e.getAll());
        }
    }
}
