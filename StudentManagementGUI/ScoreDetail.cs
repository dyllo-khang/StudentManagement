using BusinessObject;
using BusinessObject.Models;
using ManagementDAO;
using ManagementService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagementGUI
{
    public partial class ScoreDetail : Form
    {
        ISubjectService _subjectService;
        IStudentService _studentService;
        IScoreService _scoreService;
        List<StudentScore> changedScores = new List<StudentScore>();
        public ScoreDetail()
        {
            InitializeComponent();
            _studentService = new StudentService();
            _subjectService = new SubjectService();
            _scoreService = new ScoreService();
        }

        private void ScoreDetail_Load(object sender, EventArgs e)
        {
            var studentScores = _studentService.GetStudentScores();
            dgvScore.DataSource = studentScores;
            dgvScore.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvScore.Columns["FullName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            foreach (DataGridViewRow row in dgvScore.Rows)
            {
                var studentID = row.Cells["StudentID"].Value.ToString();
                var student = studentScores.FirstOrDefault(s => s.StudentID == studentID);
                if (student != null)
                {
                    row.Cells["MathScore"].Tag = _subjectService.GetSubjectIDByName("Math");
                    row.Cells["PhysicalScore"].Tag = _subjectService.GetSubjectIDByName("Physical");
                    row.Cells["ChemistryScore"].Tag = _subjectService.GetSubjectIDByName("Chemistry");
                    row.Cells["EnglishScore"].Tag = _subjectService.GetSubjectIDByName("English");
                }
            }
        }

        private void dgvScore_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var row = dgvScore.Rows[e.RowIndex];
            var studentID = row.Cells["StudentID"].Value?.ToString();
            var subjectID = row.Cells[e.ColumnIndex].Tag as string;
            if (!string.IsNullOrEmpty(studentID) && !string.IsNullOrEmpty(subjectID))
            {
                if (int.TryParse(row.Cells[e.ColumnIndex].Value?.ToString(), out int newScore))
                {
                    var existingScore = changedScores.FirstOrDefault(s => s.StudentID == studentID && s.SubjectID == subjectID);
                    if (existingScore != null)
                    {
                        existingScore.Score = newScore;
                    }
                    else
                    {
                        changedScores.Add(new StudentScore { StudentID = studentID, SubjectID = subjectID, Score = newScore });
                    }
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_scoreService.UpdateScore(changedScores))
            {
                MessageBox.Show("Score updated", "Notification", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Score is range 0-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            ScoreDetail_Load(this, e);
        }
    }
}
