using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AdvSesstion03
{
    internal class StringEqualityComparerNonGeneric : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {
           string? X=x as string;
            string? Y=y as string;
            return X?.Equals(Y, StringComparison.OrdinalIgnoreCase)??false;

        }

        public int GetHashCode(object obj)
        {
           string? Obj=obj as string;
            return Obj?.ToLower().GetHashCode() ?? 0;
        }
    }
}
