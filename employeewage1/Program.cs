
using System;

namespace EmployeeWage1
{
    class Program
    {
        static void Main(string[] args)
        {
            int Employee = 1;
            int EmployeeWage = 1;
            if (Employee == 1)
            {
                Console.WriteLine("Employee is present");
                Employee = 238 * 12;
                Console.WriteLine("Employee Wage =" + EmployeeWage);
            }
            else
                Console.WriteLine("Employee is absent");
            Console.WriteLine("No wage is calculated");
        }
    }
}

