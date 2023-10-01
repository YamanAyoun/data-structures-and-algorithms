using graph;

namespace GraphTests
{
    public class UnitTest1
    {
        [Fact]
        public void AddVertexToGraph()
        {
            // Arrange
            var graph = new Graph();

            // Act
            var result = graph.AddVertex("vertex");

            // Assert
            Assert.Equal("vertex", result);
            Assert.Equal(1, graph.Size());
            Assert.Contains("vertex", graph.GetVertices());
        }

        [Fact]
        public void AddEdgeBetweenVertices()
        {
            // Arrange
            var graph = new Graph();
            graph.AddVertex("vertex1");
            graph.AddVertex("vertex2");

            // Act
            graph.AddEdge("vertex1", "vertex2", 5);

            // Assert
            var neighborsA = graph.GetNeighbors("vertex1");
            var neighborsB = graph.GetNeighbors("vertex2");
            Assert.Equal(1, neighborsA.Count);
            Assert.Equal(1, neighborsB.Count);
            Assert.Equal(("vertex2", 5), neighborsA[0]);
            Assert.Equal(("vertex1", 5), neighborsB[0]);
        }

        [Fact]
        public void GetAllVertices()
        {
            // Arrange
            var graph = new Graph();
            graph.AddVertex("vertex1");
            graph.AddVertex("vertex2");
            graph.AddVertex("vertex3");

            // Act
            var vertices = graph.GetVertices();

            // Assert
            Assert.Equal(3, vertices.Count);
            Assert.Contains("vertex1", vertices);
            Assert.Contains("vertex2", vertices);
            Assert.Contains("vertex3", vertices);
        }

        [Fact]
        public void GetNeighborsWithWeight()
        {
            // Arrange
            var graph = new Graph();
            graph.AddVertex("vertex1");
            graph.AddVertex("vertex2");
            graph.AddEdge("vertex1", "vertex2", 5);

            // Act
            var neighborsA = graph.GetNeighbors("vertex1");
            var neighborsB = graph.GetNeighbors("vertex2");

            // Assert
            Assert.Equal(1, neighborsA.Count);
            Assert.Equal(1, neighborsB.Count);
            Assert.Equal(("vertex2", 5), neighborsA[0]);
            Assert.Equal(("vertex1", 5), neighborsB[0]);
        }

        [Fact]
        public void Size_NumberOfVertices()
        {
            // Arrange
            var graph = new Graph();
            graph.AddVertex("vertex1");
            graph.AddVertex("vertex2");
            graph.AddVertex("vertex3");

            // Act
            var size = graph.Size();

            // Assert
            Assert.Equal(3, size);
        }

    }
}