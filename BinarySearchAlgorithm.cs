using System.Diagnostics;

namespace Algorithms;
internal static class BinarySearchAlgorithm
{
    public static int? BinarySearch(List<int> list , int item)
    {
        int low = 0;
        int high = list.Count - 1;
        
        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = list[mid];

            if(guess == item)
                return guess;

            if(guess > item) high = mid + 1;

            if(guess < item) low = mid - 1;
        }
        return null;
    }
}
