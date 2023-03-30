using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;
internal class DijkstraAlgorithm
{
    private const double _infinity = double.PositiveInfinity;
    private static Dictionary<string, Dictionary<string, double>> _graph;
    private static List<string> _processed = new List<string>();


    public static void DijkstraShortestPath()
    {
        // Initialize the graph.
        _graph = new Dictionary<string, Dictionary<string, double>>()
        {
            { "start", new Dictionary<string, double>() },
            { "a", new Dictionary<string, double>() },
            { "b", new Dictionary<string, double>() },
            { "fin", new Dictionary<string, double>() },
        };
        // Initializing the cost graph.
        _graph["start"].Add("a", 6.0);
        _graph["start"].Add("b", 2.0);

        _graph["b"].Add("a", 3.0);
        _graph["b"].Add("fin", 5.0);

        _graph["a"].Add("fin", 1.0);

        var costs = new Dictionary<string, double>();
        costs["a"] = 6.0;
        costs["b"] = 2.0;
        costs["fin"] = _infinity;

        var parents = new Dictionary<string, string>()
        {
            { "a" , "start"},
            { "b" , "start" },
            {"fin" , null }

        };

        var node = FindLowestCoseNode(costs);
        while (node != null)
        {
            var cost = costs[node];
            var neighbors = _graph[node];
            foreach (var n in neighbors.Keys)
            {
                var newCost = cost + neighbors[n];
                if (newCost < costs[n])
                {
                    costs[n] = newCost;
                    parents[n] = node;
                }

            }
            _processed.Add(node);
            node = FindLowestCoseNode(costs);
        }
        Console.WriteLine(String.Join(',' , parents));
    }

    private static string FindLowestCoseNode(Dictionary<string, double> costs)
    {
        var lowestCost = _infinity;
        string lowestCostNode = null;
        foreach (var node in costs)
        {
            if (node.Value < lowestCost && !_processed.Contains(node.Key))
            {
                lowestCostNode = node.Key;
                lowestCost = node.Value;
            }
        }
        return lowestCostNode;
    }
}
