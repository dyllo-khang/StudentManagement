using BusinessObject;
using BusinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class StudentDAO
    {
        private static StudentDAO instance;
        private StudentDAO() { }
        public static StudentDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StudentDAO();
                }
                return instance;
            }
        }
        public List<Student> GettAll(string search = "")
        {
            using (var context = new StudentManagementContext())
            {
                return context.Students.Include(s => s.Class).ToList()
                                     .Where(p => p.FullName.Contains(search, StringComparison.OrdinalIgnoreCase))
                                     .ToList();
            }
        }

        public List<StudentScoreViewModel> GetStudentScores()
        {
            using (var context = new StudentManagementContext())
            {
                var studentScores = from student in context.Students
                                    let mathScore = student.Scores.FirstOrDefault(s => s.Subject.SubjectName == "Math").ScoreValue
                                    let physicalScore = student.Scores.FirstOrDefault(s => s.Subject.SubjectName == "Physical").ScoreValue
                                    let chemistryScore = student.Scores.FirstOrDefault(s => s.Subject.SubjectName == "Chemistry").ScoreValue
                                    let englishScore = student.Scores.FirstOrDefault(s => s.Subject.SubjectName == "English").ScoreValue
                                    select new StudentScoreViewModel
                                    {
                                        StudentID = student.StudentId,
                                        FullName = student.FullName,
                                        ClassName = student.Class.ClassName,
                                        ChemistryScore = (float?)chemistryScore,
                                        EnglishScore = (float?)englishScore,
                                        MathScore = (float?)mathScore,
                                        PhysicalScore = (float?)physicalScore
                                    };

                return studentScores.ToList();
            }
        }
        public bool AddStudent(Student student)
        {
            try
            {
                using (var context = new StudentManagementContext())
                {
                    context.Students.Add(student);
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteStudent(string id)
        {
            try
            {
                using (var context = new StudentManagementContext())
                {
                    var scoreToDelete = context.Scores.Where(s => s.StudentId.Equals(id)).ToList();
                    context.Scores.RemoveRange(scoreToDelete);
                    var studentDel = context.Students.Find(id);
                    if(studentDel != null)
                    {
                        context.Students.Remove(studentDel);
                    }
                    context.SaveChanges();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpDateStudent(Student student)
        {
            try
            {
                using (var context = new StudentManagementContext())
                {
                    context.Entry(student).State = EntityState.Modified;
                    context.SaveChanges();
                }
                return true;
            }
            catch { return false; }
        }
    }
}
