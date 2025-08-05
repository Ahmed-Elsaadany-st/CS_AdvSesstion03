using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_AdvSesstion03
{
    internal class StringComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return String.Compare(y, x);
        }
    }
}
