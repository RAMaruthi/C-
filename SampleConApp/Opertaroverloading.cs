using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleConApp
{
    class Employee1
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public int EmpSalary { get; set; }

        public static Employee1 operator +(Employee1 emp, int amout)
        {
            emp.EmpSalary += amout;
            return emp;
        }

        public static Employee1 operator -(Employee1 emp, int amout)
        {
            emp.EmpSalary -= amout;
            return emp;
        }
        public static Employee1 operator *(Employee1 emp,int amout)
        {
            emp.EmpSalary *= amout;
            return emp;
        }


    }


    class Opertaroverloading
    {
        static void Main(string[] args)
        {
            Employee1 emp = new Employee1
            {
                EmpId = 111, EmpName = "TestName", EmpSalary = 56000
                };



            emp += 2000;
            Console.WriteLine("The Current Salary"+emp.EmpSalary);
            emp *= 4000;
            Console.WriteLine("The Current Salary" + emp.EmpSalary);
        }


}
}



