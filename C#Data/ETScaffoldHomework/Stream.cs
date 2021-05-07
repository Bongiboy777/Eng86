using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class Stream
    {
        public Stream()
        {
            Courses = new HashSet<Course>();
            Trainees = new HashSet<Trainee>();
        }

        public int StreamId { get; set; }
        public int? AcademyId { get; set; }
        public string StreamDescription { get; set; }
        public string StreamName { get; set; }

        public virtual Academy Academy { get; set; }
        public virtual ICollection<Course> Courses { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
