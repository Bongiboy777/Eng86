using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class Employee1
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int? Salary { get; set; }
        public int? Department { get; set; }

        public virtual Employee DepartmentNavigation { get; set; }
    }
}
