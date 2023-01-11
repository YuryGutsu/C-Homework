

namespace UniversityEmployee;

internal class Teacher: UniversityEmployee
{
    public Course Course { get; set; }
    public Teacher(Person person, string taxId, Course course) : base (person, taxId)
    {
        Course = course;
    }

    public override string GetOfficialDuties()
    {
        return $"{base.GetOfficialDuties()} teacher of {Course.CourseName} {Course.CourseDescribtion}";
    }
}
