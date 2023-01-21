
namespace UniversityEmployee;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    
    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }
    public override bool Equals(object obj)
    {
        if (obj == null || obj is not Person person)
        {
            return false;
        }

        return person.FirstName.Equals(FirstName)
            && person.LastName.Equals(LastName);
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}
