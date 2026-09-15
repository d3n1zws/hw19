using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    internal class Employee
    {
        public Employee(int id, string name, int salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine($"Id : {Id}, Name : {Name}, Salary: {Salary}");
        }
    }
}
