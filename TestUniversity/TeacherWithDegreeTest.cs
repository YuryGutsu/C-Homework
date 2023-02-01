using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]
public class TeacherWithDegreeTest
    {

    [TestMethod]
    public void TestTeacherWithDegreeOverrideGetOfficialDutiesPositive()
    {
        TeacherWithDegree teacher = new TeacherWithDegree(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"),
                          "scienceDegree", "rank");
        string getOfficialDuties = "I'm Dddd Mnnn ID# GG1989 teacher of courseName courseDescribtion scienceDegree rank";
        Assert.AreEqual(teacher.GetOfficialDuties(), getOfficialDuties);
    }

    [TestMethod]
    public void TestTeacherWithDegreeEqualsPositive()
    {
        TeacherWithDegree teacher = new TeacherWithDegree(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"),
                          "scienceDegree", "rank");
        TeacherWithDegree t = new TeacherWithDegree(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"),
                          "scienceDegree", "rank");
        Assert.AreEqual(teacher, t);
    }

    [TestMethod]
    public void TestTeacherWithDegreeEqualsNegative()
    {
        TeacherWithDegree teacher = new TeacherWithDegree(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"),
                          "scienceDegree", "rank");
        TeacherWithDegree t = new TeacherWithDegree(new Person("Dddd", "Mnnn"),
                          "GG1989",
                          new Course("courseName", "courseDescribtion"),
                          "scienceDegree", "RANK");
        Assert.AreNotEqual(teacher, t);
    }
}

