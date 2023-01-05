using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysNew
{
    internal class CandidateInfo
    {
        public Person Person { get; }
        public SubjectScore[] subjectScores { get; }

        public CandidateInfo(Person person, SubjectScore[] scores)
        {
            this.Person = person;
            this.subjectScores = scores;       
        }
    }
}
