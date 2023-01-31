namespace UniversityEmployee;

public class Course
{
    public string CourseName { get; set; }
    public string CourseDescribtion { get; set; }
    public Course(string courseName, string courseDescribtion)
    {
        CourseName = courseName;
        CourseDescribtion = courseDescribtion;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null || obj is not Course course)
        {
            return false;
        }

        return course.CourseName.Equals(CourseName);
    }

    public override int GetHashCode()
    {
        return CourseName.GetHashCode();
    }
}
