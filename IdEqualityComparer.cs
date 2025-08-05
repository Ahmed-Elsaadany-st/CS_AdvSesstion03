
using System.Diagnostics.CodeAnalysis;

namespace CS_AdvSesstion03
{
    internal class IdEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
           if(x == null && y == null) return false;
            return x.Equals(y);
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}