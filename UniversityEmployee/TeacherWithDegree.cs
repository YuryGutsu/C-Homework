

namespace UniversityEmployee;

public class TeacherWithDegree:Teacher
{
    public string ScienceDegree { get; set; }
    public string Rank { get; set; }

    public TeacherWithDegree ( Person person, string taxId, Course course, string scienceDegree, string rank) :
                        base (person, taxId, course)
    {
        ScienceDegree = scienceDegree;
        Rank = rank;
    }
    public override string GetOfficialDuties()
    {
        return $"{base.GetOfficialDuties()} {ScienceDegree} {Rank}";
    }
    public override bool Equals(object obj)
    {
        if (obj == null || obj is not TeacherWithDegree teacherWithDegree)
        {
            return false;
        }

        return base.Equals(obj) && teacherWithDegree.Rank.Equals(Rank)
            && teacherWithDegree.ScienceDegree.Equals(ScienceDegree);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
