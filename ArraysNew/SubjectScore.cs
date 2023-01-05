using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysNew
{
    internal class SubjectScore
    {
        private int _score;
        public int Score
        {
            get
            {
                return _score; 
            }
                set
            {
                if(value >0 && value <= 100)
                {
                    _score = value;
                }
            }            
        }  
        public string SubjectName { get; set; }

        public SubjectScore(int score, string subjectName)
        {
            this.Score = score;
            this.SubjectName = subjectName;
        }
    }
}
