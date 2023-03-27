namespace Algorithms;
internal static class TheSumFuntion
{
    public static int Sum(IEnumerable<int> list)
    {
        if(!list.Any())
            return 0;
        return list.First() + Sum(list.Skip(1));
    }
}
