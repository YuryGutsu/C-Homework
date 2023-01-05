using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysNew
{
    internal class CandidateInfo
    {
        public Person Person { get; set; }
        public SubjectScore[] subjectScores { get; set; }

        public CandidateInfo(Person person, SubjectScore[] scores)
        {
            Person = person;
            subjectScores = scores;       
        }
    }
}
