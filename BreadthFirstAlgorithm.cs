using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms;
internal class BreadthFirstAlgorithm
{
    private static Dictionary<char, List<char>> _graph = new()
    {
        { 'a', new List<char> {'b' , 'c' } },
        { 'b', new List<char> { 'd' }},
        { 'c', new List<char> { 'e' } },
        { 'd', new List<char> { 'f' }},
        { 'e', new List<char> { }},
        { 'f', new List<char> { }}
    };

    public static bool BreadthFirst(char sourceNode)
    {
        var searchQueue = new Queue<char>(_graph[sourceNode]);
        var searchedNodes = new List<char>();
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
                    searchedNodes.Add(node);
                }
            }
        }
        return false;
    }
    private static bool PersonIsSeller(char character)
    {
        return character == 'a';
    }
}
