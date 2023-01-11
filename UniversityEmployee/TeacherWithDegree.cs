

namespace UniversityEmployee;

internal class TeacherWithDegree:Teacher
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
}
