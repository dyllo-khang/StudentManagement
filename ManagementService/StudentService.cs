using BusinessObject;
using BusinessObject.Models;
using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class StudentService : IStudentService
    {
        private IStudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public bool AddStudent(Student student) => _studentRepository.AddStudent(student);

        public bool DeleteStudent(string id) => _studentRepository.DeleteStudent(id);

        public List<Student> GetAll(string search = "") => _studentRepository.GetAll(search);

        public List<StudentScoreViewModel> GetStudentScores() => _studentRepository.GetStudentScores();

        public bool UpdateStudent(Student student) => _studentRepository.UpdateStudent(student);
    }
}
