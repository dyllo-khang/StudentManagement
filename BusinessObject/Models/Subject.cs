using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Subject
    {
        public Subject()
        {
            Scores = new HashSet<Score>();
        }

        public string SubjectId { get; set; } = null!;
        public string SubjectName { get; set; } = null!;

        public virtual ICollection<Score> Scores { get; set; }
    }
}
