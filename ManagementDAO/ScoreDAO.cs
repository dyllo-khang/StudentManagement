using BusinessObject;
using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDAO
{
    public class ScoreDAO
    {
        private static ScoreDAO instance;
        private ScoreDAO() { }

        public static ScoreDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ScoreDAO();
                }
                return instance;
            }
        }

        public bool UpdateScore(List<StudentScore> changedScores)
        {
            using (var context = new StudentManagementContext())
            {
                try
                {
                    foreach (var changedScore in changedScores)
                    {
                        var score = context.Scores.FirstOrDefault(s => s.StudentId.Equals(changedScore.StudentID) && s.SubjectId.Equals(changedScore.SubjectID));
                        if (score != null)
                        {
                            score.ScoreValue = changedScore.Score;
                        }
                        else
                        {
                            context.Scores.Add(new Score { StudentId = changedScore.StudentID, SubjectId = changedScore.SubjectID, ScoreValue = changedScore.Score });
                        }
                    }
                    context.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

    }
}
