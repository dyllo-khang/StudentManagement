using BusinessObject;
using ManagementRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementService
{
    public class ScoreService : IScoreService
    {
        private IScoreRepository _scoreRepository;
        public ScoreService()
        {
            _scoreRepository = new ScoreRepository();
        }
        public bool UpdateScore(List<StudentScore> changedScores) => _scoreRepository.UpdateScore(changedScores);
    }
}
