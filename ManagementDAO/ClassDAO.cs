using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class ClassDAO
    {
        private static ClassDAO instance;
        private ClassDAO() { }
        public static ClassDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ClassDAO();
                }
                return instance;
            }
        }

        public List<Class> GetAll()
        {
            using (var context = new StudentManagementContext())
            {
                return context.Classes.ToList();
            }
        }
    }
}
