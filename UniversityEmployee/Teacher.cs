namespace UniversityEmployee;

public class Teacher: UniversityEmployee
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
    public override bool Equals(object obj)
    {
        if (obj == null || obj is not Teacher teacher)
        {
            return false;
        }

        return base.Equals(obj) && teacher.Course.Equals(Course);
    }
    public override int GetHashCode()
    {
        return Course.GetHashCode();
    }
}
