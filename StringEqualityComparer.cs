using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AdvSesstion03
{
    internal class StringEqualityComparer : IEqualityComparer<string>

    {
        public bool Equals(string? x, string? y)
        {
            return x?.Equals(y, StringComparison.OrdinalIgnoreCase) ?? false;

        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj?.ToLower().GetHashCode() ?? 0;
        }
    }
}
