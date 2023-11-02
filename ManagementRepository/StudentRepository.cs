using BusinessObject;
using BusinessObject.Models;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public class StudentRepository : IStudentRepository
    {
        public bool AddStudent(Student student) => StudentDAO.Instance.AddStudent(student);

        public bool DeleteStudent(string id) => StudentDAO.Instance.DeleteStudent(id);

        public List<Student> GetAll(string search = "") => StudentDAO.Instance.GettAll(search);

        public List<StudentScoreViewModel> GetStudentScores() =>StudentDAO.Instance.GetStudentScores();

        public bool UpdateStudent(Student student) => StudentDAO.Instance.UpDateStudent(student);
    }
}
