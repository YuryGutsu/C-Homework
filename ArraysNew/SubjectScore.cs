using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysNew
{
    internal class SubjectScore
    {
        public int Score { get; }  
        public string SubjectName { get; }

        public SubjectScore(int score, string subjectName)
        {
            this.Score = score;
            this.SubjectName = subjectName;
        }
    }
}
