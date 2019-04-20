using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {

            doSmth();
            // departmentName -> List<Employee>
            var employeesByDepartments = new Dictionary<string, List<Employee>>();

            int count = int.Parse(Console.ReadLine());

            while (count-- > 0)
            {
                // Pesho 120.00 Dev Development pesho @abv.bg 28
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string name = input[0];
                double salary = double.Parse(input[1]);
                string position = input[2];
                string department = input[3];

                string email = "n/a";
                int age = -1;

                if (input.Length == 6)
                {
                    email = input[4];
                    age = int.Parse(input[5]);
                }
                else if (input[4].Contains("@"))
                {
                    email = input[4];
                }
                else
                {
                    age = int.Parse(input[4]);
                }

                if (!employeesByDepartments.ContainsKey(department))
                {
                    employeesByDepartments.Add(department, new List<Employee>());
                }

                Employee currentEmployee = new Employee();
                currentEmployee.Name = name;
                currentEmployee.Age = age;
                currentEmployee.Department = department;
                currentEmployee.Position = position;
                currentEmployee.Email = email;
                currentEmployee.Salary = salary;

                employeesByDepartments[department].Add(currentEmployee);
            }

            PrintResult(employeesByDepartments);
        }

        private static void PrintResult(Dictionary<string, List<Employee>> employeesByDepartments)
        {
            Dictionary<string, List<Employee>> kvp = employeesByDepartments
                 .OrderByDescending(x => x.Value
                 .Average(emp => emp.Salary))
                 .Take(1)
                 .ToDictionary(e => e.Key, e => e.Value);

            Console.WriteLine($"Highest Average Salary: {kvp.First().Key}");
            Console.WriteLine($"{string.Join("\n", kvp.First().Value.OrderByDescending(e => e.Salary))}");
        }

        public static void doSmth()
        {
            Employee pesho = new Employee("Pesho", 2000, "dev", "it", "pesho@abv.bg", 15);
            Employee alex = new Employee("Alex", 200, "dev", "it");

            pesho.Projects.Add("Cvetq");

            Console.WriteLine();

        }
    }
}
