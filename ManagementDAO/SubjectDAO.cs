using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class SubjectDAO
    {
        private static SubjectDAO instance;
        private SubjectDAO() { }
        public static SubjectDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SubjectDAO();
                }
                return instance;
            }
        }
        public string GetSubjectIDByName(string subjectName)
        {
            using (var context = new StudentManagementContext())
            {
                var subject = context.Subjects.FirstOrDefault(s => s.SubjectName == subjectName);
                return subject?.SubjectId;
            }
        }
    }
}
