using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public class SubjectRepository : ISubjectRepository
    {
        public string GetSubjectIDByName(string subjectName) => SubjectDAO.Instance.GetSubjectIDByName(subjectName);
    }
}
