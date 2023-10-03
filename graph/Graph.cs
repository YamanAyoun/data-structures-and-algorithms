using System;
using System.Collections.Generic;

namespace graph
{

    public class Graph
    {
        private Dictionary<string, List<(string, int)>> vertices;

        public Graph()
        {
            vertices = new Dictionary<string, List<(string, int)>>();
        }

        public string AddVertex(string value)
        {
            if (!vertices.ContainsKey(value))
            {
                vertices[value] = new List<(string, int)>();
            }
            return value;
        }

        public void AddEdge(string vertex1, string vertex2, int weight = 0)
        {
            if (vertices.ContainsKey(vertex1) && vertices.ContainsKey(vertex2))
            {
                vertices[vertex1].Add((vertex2, weight));
                vertices[vertex2].Add((vertex1, weight));
            }
        }

        public List<string> GetVertices()
        {
            return new List<string>(vertices.Keys);
        }

        public List<(string, int)> GetNeighbors(string vertex)
        {
            if (vertices.ContainsKey(vertex))
            {
                return vertices[vertex];
            }
            return new List<(string, int)>();
        }

        public int Size()
        {
            return vertices.Count;
        }

        public List<string> BreadthFirst(string value)
        {
            List<string> listVertex = new List<string>();
            Queue<string> queue = new Queue<string>();
            Dictionary<string, bool> visited = new Dictionary<string, bool>();

            if (vertices.ContainsKey(value))
            {
                queue.Enqueue(value);
                visited[value] = true;

                while (queue.Count > 0)
                {
                    string currentVertex = queue.Dequeue();
                    listVertex.Add(currentVertex);

                    foreach (var neighbor in vertices[currentVertex])
                    {
                        if (!visited.ContainsKey(neighbor.Item1))
                        {
                            queue.Enqueue(neighbor.Item1);
                            visited[neighbor.Item1] = true;
                        }
                    }
                }
            }

            return listVertex;
        }

    }
}
