using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Score
    {
        public string StudentId { get; set; } = null!;
        public string SubjectId { get; set; } = null!;
        public double? ScoreValue { get; set; }

        public virtual Student Student { get; set; } = null!;
        public virtual Subject Subject { get; set; } = null!;
    }
}
