using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace _12_Employee
{
    internal class EmployeeRepository
    {
        public List<Employee> employeesList;
        private long id;
        public EmployeeRepository()
        {
            employeesList = new List<Employee>();
        }
        internal void Clear()
        {
            employeesList.Clear();
        }

        internal int CountEmployees()
        {
            return employeesList.Count;
        }
        public long NextId()
        {
            id++;
            return id;
        }
        internal Employee CreateEmployee(string name, string profession)
        {
            NextId();
            Employee emp = new Employee(id, name, profession);
            employeesList.Add(emp);
            return emp;

        }

        internal void SaveEmployee(Employee simon)
        {
            NextId();
            Employee emp = new Employee(simon.Id, simon.Name, simon.Type);
        }

        internal Employee LoadEmployee(long id)
        {
            foreach(Employee emp in employeesList)
            {
                if (emp.Id == id)
                    return emp;
            }
            return null;
        }

        internal List<Employee> FindAllEmployees()
        {
            return employeesList;
        }
    }
}