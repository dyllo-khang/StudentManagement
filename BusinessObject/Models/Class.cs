using System;
using System.Collections.Generic;

namespace BusinessObject.Models
{
    public partial class Class
    {
        public Class()
        {
            Students = new HashSet<Student>();
        }

        public string ClassId { get; set; } = null!;
        public string ClassName { get; set; } = null!;
        public string? Description { get; set; }

        public virtual ICollection<Student> Students { get; set; }
    }
}
