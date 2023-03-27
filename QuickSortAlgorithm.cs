namespace Algorithms;
internal class QuickSortAlgorithm
{
    public static IEnumerable<int> QuickSort(IEnumerable<int> input)
    {
        if(input.Count() <= 2) return input;

        var pivot = input.First();
        var greater = input.Skip(1).Where( x => x > pivot);
        var less = input.Skip(1).Where( x => x <= pivot );
        
        return QuickSort(less).Concat(new List<int>() { pivot}).Concat(QuickSort(greater));
    }
}
