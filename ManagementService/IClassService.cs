using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public interface IClassService
    {
        List<Class> GetAll();
    }
}
