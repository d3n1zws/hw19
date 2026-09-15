using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees = new List<Employee>();
        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }
        public void GetEmployeeById(int id)
        {
            Employee? employee = Employees.Find(e => e.Id == id);
            if (employee == null)
            {
                throw new Exception("id tapilmadi");
            }
        }
        public void RemoveEmployee(Employee employee)
        {
            Employee? employee1 = Employees.Find(e => employee == e);
            if (employee1 == null)
            {
                throw new Exception("employee tapilmadi");
            }
            Employees.Remove(employee1);
        }
    }
}
