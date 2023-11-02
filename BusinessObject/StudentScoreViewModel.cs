using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObject
{
    public class StudentScoreViewModel
    {
        public string? StudentID { get; set; }
        public string? FullName { get; set; }
        public string? ClassName { get; set; }
        public float? ChemistryScore { get; set; }
        public float? EnglishScore { get; set; }
        public float? MathScore { get; set; }
        public float? PhysicalScore { get; set; }
    }
}
