using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Domain.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public DateTime Birthday { get; set; }
        public int Salary { get; set; }

        public Employee(string name, string surname, DateTime birthday, int salary)
        {
            Name = name;
            Surname = surname;
            Birthday = birthday;
            Salary = salary;
        }

        public static Employee[] List () 
        { 
            Employee employee1 = new Employee("John", "Doe", new DateTime(1990, 5, 15), 500);
            Employee employee2 = new Employee("Alice", "Smith", new DateTime(1994, 10, 8), 2500);
            Employee employee3 = new Employee("Bob", "Johnson", new DateTime(1993, 3, 25), 2200);
            Employee employee4 = new Employee("Emily", "Williams", new DateTime(1998, 7, 12), 1800);
            Employee employee5 = new Employee("Michael", "Brown", new DateTime(1995, 12, 30), 5800);
            Employee[] employees = { employee1, employee2, employee3, employee4, employee5 };
            return employees;
        }

        public static void Find()
        {
            DateTime firstdate = new DateTime(1993, 1, 25);
            DateTime lastdate = new DateTime(1996, 12, 15);
            Employee[] list = List();
            int counter = 0;
            foreach (Employee e in list)
            {
                if (e.Birthday>=firstdate && e.Birthday<=lastdate && e.Salary>=2000)
                {
                    counter++;
                }
            }
            Console.WriteLine(counter);
        }
    }
}
