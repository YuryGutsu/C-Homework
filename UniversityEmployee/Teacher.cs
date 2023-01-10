

namespace UniversityEmployee;

internal class Teacher: UniversityEmployee
{
    public Course Course { get; set; }
    public Teacher(Person person, string taxID, Course course) : base (person, taxID)
    {
        Course = course;
    }

    public override string GetOfficialDuties()
    {
        return $"{base.GetOfficialDuties()} teacher of {Course.CourseName} {Course.CourseDescribtion}";
    }
}
