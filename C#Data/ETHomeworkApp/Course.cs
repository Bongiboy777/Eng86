using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class Course
    {
        public Course()
        {
            Trainees = new HashSet<Trainee>();
            Trainers = new HashSet<Trainer>();
        }

        public int CourseId { get; set; }
        public int? StreamId { get; set; }
        public string CourseDescription { get; set; }
        public string CourseName { get; set; }
        public int? CourseLength { get; set; }

        public virtual Stream Stream { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
        public virtual ICollection<Trainer> Trainers { get; set; }
    }
}
