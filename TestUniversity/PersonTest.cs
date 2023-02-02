using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class PersonTest
{
    [TestMethod]
    public void TestPersonsEqualsPositive()
    {
        var person = new Person("Bob", "Dylan");
        var p = new Person("Bob", "Dylan");
        Assert.AreEqual(person, p);
    }

    [TestMethod]
    public void TestPersonsFirstNameEqualsNegative()
    {
        var person = new Person("Bob", "Dylan");
        var p = new Person("BBB", "Dylan");
        Assert.AreNotEqual(person, p);
    }

    [TestMethod]
    public void TestPersonsLastNameEqualsNegative()
    {
        var person = new Person("Bob", "Dylan");
        var p = new Person("BBB", "DDDDD");
        Assert.AreNotEqual(person, p);
    }

    [TestMethod]
    public void TestPersonFullNameLengthThrowsException()
    {
        var ex = Assert.ThrowsException<ArgumentException>(() => new Person("BobBobBobBobBobBob", "Dylan").FullNameLength());
        Assert.AreEqual("FirstName and LastName length must be <=15", ex.Message);
    }
}
