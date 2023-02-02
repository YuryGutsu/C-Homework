using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class CourseTest
{
    [TestMethod]
    public void TestCoursesEqualsPositive()
    {
        var course = new Course("Math", "Algebra");
        var c = new Course("Math", "Algebra");
        Assert.AreEqual(course, c);
    }

    [TestMethod]
    public void TestCoursesEqualsNegative()
    {
        var course = new Course("Math", "Algebra");
        var c = new Course("History", "Algebra");
        Assert.AreNotEqual(course, c);
    }
}
