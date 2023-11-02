using BusinessObject;
using ManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementRepository
{
    public class ScoreRepository : IScoreRepository
    {
        public bool UpdateScore(List<StudentScore> changedScores) => ScoreDAO.Instance.UpdateScore(changedScores);
        
    }
}
