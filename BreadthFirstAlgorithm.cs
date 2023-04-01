using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;
internal class BreadthFirstAlgorithm
{
    private static Dictionary<string, List<string>> _graph = new()
    {
        { "a", new List<string> {"b" , "c" } },
        { "b", new List<string> { "d" }},
        { "c", new List<string> { "e" } },
        { "d", new List<string> { "f" }},
        { "e", new List<string> { }},
        { "f", new List<string> { }}
    };

    public static bool BreadthFirst(string sourceNode)
    {
        var searchQueue = new Queue<string>(_graph[sourceNode]);
        var searchedNodes = new List<string>();

        var parents = new Dictionary<string, string>();
        foreach (var node in _graph.Keys)
        {
            if (_graph[sourceNode].Contains(node))
            parents.Add(node, sourceNode);

            else
            parents.Add(node, null);
        }

        while (searchQueue.Any())
        {
            var node = searchQueue.Dequeue();
            if (!searchedNodes.Contains(node))
            {
                Console.WriteLine(node);
                if (PersonIsSeller(node))
                {
                    Console.WriteLine("the condition is true" + node);
                    return true;
                }
                else
                {
                    searchQueue = new(searchQueue.Concat(_graph[node]));
                    foreach (var item in _graph[node])
                    {
                        parents[item] = node;
                    }
                    searchedNodes.Add(node);
                }
            }
        }
        foreach (var item in parents)
        {
            Console.WriteLine($"{item.Value} is the parent of {item.Key}");
        }
        return false;
    }
    private static bool PersonIsSeller(string character)
    {
        return character == "a";
    }
}
