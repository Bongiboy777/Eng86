using System;
using System.Collections.Generic;

#nullable disable

namespace ETScaffoldHomework
{
    public partial class Academy
    {
        public Academy()
        {
            Streams = new HashSet<Stream>();
            Trainees = new HashSet<Trainee>();
        }

        public int AcademyId { get; set; }
        public string AcademyAddress { get; set; }
        public string AcademyName { get; set; }
        public bool? AcademyPopup { get; set; }
        public DateTime? AcademyStartdate { get; set; }

        public virtual ICollection<Stream> Streams { get; set; }
        public virtual ICollection<Trainee> Trainees { get; set; }
    }
}
