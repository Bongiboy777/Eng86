using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class Trainee
    {
        public int TraineeId { get; set; }
        public int? AcademyId { get; set; }
        public int? StreamId { get; set; }
        public int? CourseId { get; set; }
        public int? TrainerId { get; set; }
        public string TraineeName { get; set; }
        public DateTime? TraineeJoindate { get; set; }

        public virtual Academy Academy { get; set; }
        public virtual Course Course { get; set; }
        public virtual Stream Stream { get; set; }
        public virtual Trainer Trainer { get; set; }
    }
}
