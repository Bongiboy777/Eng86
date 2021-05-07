using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class Trainer
    {
        public Trainer()
        {
            Trainees = new HashSet<Trainee>();
        }

        public int TrainerId { get; set; }
        public int? CourseId { get; set; }
        public string TrainerEmail { get; set; }
        public string TrainerName { get; set; }
        public DateTime? TrainerJoindate { get; set; }

        public virtual Course Course { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
