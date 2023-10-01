# Graph

## Challenge
Implement your own Graph. The graph should be represented as an adjacency list, with the following methods: {add vertex, add edge, get vertices, get neighbors and size}

## Approach & Efficiency
- Time complexity for add vertex and Size methods are O(1).
- Time complexity for add edge , GetNodes and GetNeighbors methods are O(n).

## API
1. add vertex
2. add edge
3. get vertices
4. get neighbors
5. size

## Code
```
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
     
 }
```
## Test Code([Test](../GraphTests/UnitTest1.cs))
