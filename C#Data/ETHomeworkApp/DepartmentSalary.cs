using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class DepartmentSalary
    {
        public int? EmployeeId { get; set; }
        public int? DepartmentId { get; set; }

        public virtual Employee Employee { get; set; }
    }
}
