

namespace ArraysNew;

internal class CandidateInfo
{
    public Person Person { get; set; }
    public SubjectScore[] SubjectScores { get; set; }

    public CandidateInfo(Person person, SubjectScore[] scores)
    {
        Person = person;
        SubjectScores = scores;       
    }
}
