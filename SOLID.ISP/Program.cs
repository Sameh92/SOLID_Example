using System;

namespace SOLID.ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //  var emplyees = Before.Repository.loadEmployee();
            var emplyees = After.Repository.loadEmployee();
            foreach (var employee in emplyees)
            {
                Console.WriteLine(employee.PrintSalarySlip());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
