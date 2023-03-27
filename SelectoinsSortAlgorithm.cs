namespace Algorithms;
internal static class SelectoinsSortAlgorithm
{
    private static int FindSmallest(List<int> list)
    {
        var smallestIndex = 0;
        var smallest = list[smallestIndex];

        for (int i = 0; i < list.Count; i++)
        {
            if(smallest > list[i])
            {
                smallestIndex = i;
                smallest= list[i];
            }
        }
        return smallestIndex;
    }
    public static List<int> SelectionSort(List<int> list)
    {
        List<int> result = new();
        var count = list.Count;
        for (int i = 0; i < count; i++)
        {
            int smallest = FindSmallest(list);
            result.Add(list[smallest]);
            list.RemoveAt(smallest);
        }
        return result;
    }
}
