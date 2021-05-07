using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class Employee
    {
        public Employee()
        {
            Employee1s = new HashSet<Employee1>();
        }

        public int EmployeeId { get; set; }
        public int Salary { get; set; }

        public virtual ICollection<Employee1> Employee1s { get; set; }
    }
}
