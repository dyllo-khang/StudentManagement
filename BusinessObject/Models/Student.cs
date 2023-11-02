using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Student
    {
        public Student()
        {
            Scores = new HashSet<Score>();
        }

        public string StudentId { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? Email { get; set; }
        public string? ClassId { get; set; }

        public virtual Class? Class { get; set; }
        public virtual ICollection<Score> Scores { get; set; }
    }
}
