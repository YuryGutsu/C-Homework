using UniversityEmployee;

namespace UniversityUnitTest;

[TestClass]

public class AddressTest
{
    Address address = new Address("Minsk", "ul. Brovki", 1);

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestNumberOfBuildingThrowsException()
    {
        _ = new Address("Minsk", "ul. Brovki", 1001);
    }

    [TestMethod]
    public void TestAddressesEqualsPositive()
    {
        var a = new Address("Minsk", "ul. Brovki", 1);
        Assert.AreEqual(address, a);
    }

    [TestMethod]
    public void TestAddressesEqualsNegative()
    {
        var a = new Address("Orsha", "ul. Brovki", 1);
        Assert.AreNotEqual(address, a);
    }

    [TestMethod]
    public void AddressesGetHashCodesAreEquals()
    {
        var a = new Address("Minsk", "ul. Brovki", 1);
        Assert.AreNotEqual(address.GetHashCode, a.GetHashCode);
    }
}
