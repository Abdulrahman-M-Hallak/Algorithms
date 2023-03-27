namespace Algorithms;
internal static class RecursiveSumAlgorithm
{
    public static int Sum(IEnumerable<int> list)
    {
        if(!list.Any())
            return 0;
        return list.First() + Sum(list.Skip(1));
    }
    public static int NumberOfElements(IEnumerable<int> list)
    {
        if(!list.Any()) return 0;
        
        return 1 + NumberOfElements(list.Skip(1));
    }
}
