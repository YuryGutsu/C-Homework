

namespace UniversityEmployee;

internal class Course
{
    public string CourseName { get; set; }
    public string CourseDescribtion { get; set; }
    public Course(string courseName, string courseDescribtion)
    {
        CourseName = courseName;
        CourseDescribtion = courseDescribtion;
    }
}
