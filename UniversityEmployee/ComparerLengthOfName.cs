namespace UniversityEmployee;

public class ComparerLengthOfName : IComparer<UniversityEmployee>
{
    int IComparer<UniversityEmployee>.Compare(UniversityEmployee? x, UniversityEmployee? y)
    {
        return y.Person.FullNameLength() - x.Person.FullNameLength();
    }
}
