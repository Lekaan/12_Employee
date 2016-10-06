using System.Collections.Generic;

namespace _12_Employee
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public long Id { get; set; }

        public Employee(long id, string name, string type)
        {
            Name = name;
            Type = type;
            Id = id;
        }

        
    }
}