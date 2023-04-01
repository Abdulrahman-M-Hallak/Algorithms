namespace Algorithms;
internal class Program
{
    static void Main(string[] args)
    {
        List<int> ints = new() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        Console.WriteLine(BinarySearchAlgorithm.BinarySearch(ints, 8));

        Console.WriteLine(String.Join(',', SelectoinsSortAlgorithm.SelectionSort(new() { 1, 2, 3, 43, 5, 645, 323, 12, 324, 5, 23, 51, 5, 31 })));

        List<int> ints2 = new() { 1, 2, 3, 43, 5, 645, 323, 12, 324, 5, 23, 51, 5, 31 };
        Console.WriteLine(RecursiveSumAlgorithm.Sum(ints2));

        Console.WriteLine(RecursiveSumAlgorithm.NumberOfElements(ints2));

        Console.WriteLine(String.Join(',' ,QuickSortAlgorithm.QuickSort( ints2)));

        BreadthFirstAlgorithm.BreadthFirst("a");

        Console.WriteLine("***********************************************");
        DijkstraAlgorithm.DijkstraShortestPath();

        Console.WriteLine("***********************************************");
        ApproximationAlgorithm.FindBestStates();
    }
}
