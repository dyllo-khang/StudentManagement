using BusinessObject.Models;
using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class ClassService : IClassService
    {
        private IClassRepository _classRepository;
        public ClassService()
        {
            _classRepository = new ClassRepository();
        }
        public List<Class> GetAll() => _classRepository.GetAll();


    }
}
