using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public interface ISubjectRepository
    {
        string GetSubjectIDByName(string subjectName);
    }
}
