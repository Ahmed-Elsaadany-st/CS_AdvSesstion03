
namespace CS_AdvSesstion03
{
    internal class intComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y.CompareTo(x);
        }
    }
}