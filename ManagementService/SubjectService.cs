using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class SubjectService : ISubjectService
    {
        private ISubjectRepository _subjectRepository;
        public SubjectService()
        {
            _subjectRepository = new SubjectRepository();
        }
        public string GetSubjectIDByName(string subjectName) => _subjectRepository.GetSubjectIDByName(subjectName);
    }
}
