using System.Collections.Specialized;

namespace Algorithms;
internal class ApproximationAlgorithm
{
    private static HashSet<string> _statesNeeded = new HashSet<string>()
    {
        "mt", "wa", "or", "id", "nv", "ut", "ca", "az"
    };
    private static Dictionary<string, HashSet<string>> _stations = new Dictionary<string, HashSet<string>>()
    {
        {"kone" , new(){"id" , "nv" , "ut"} },
        {"kto" , new(){"wa", "id", "mt"} },
        {"kthree" , new(){"or" , "nv" , "ka"} },
        {"kfour" , new(){"nv" , "ut"} },
        {"kfive", new(){"ca" , "az"} }
    };

    public static void FindBestStates()
    {
        var finalStations = new HashSet<string>();

        while (_statesNeeded.Any())
        {
            string bestStattion = null;
            var statesCovered = new HashSet<string>();
            foreach (var station in _stations)
            {
                var covered = new HashSet<string>(_statesNeeded.Intersect(station.Value));
                if (covered.Count > statesCovered.Count)
                {
                    bestStattion = station.Key;
                    statesCovered = covered;
                }
            }
            _statesNeeded.RemoveWhere(x => statesCovered.Contains(x));
            finalStations.Add(bestStattion);
        }
        Console.WriteLine(string.Join(',', finalStations));
    }
}
