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


        [Fact]
        public void BreadthFirst()
        {
            // Arrange
            Graph graph = new Graph();
            graph.AddVertex("Pandora");
            graph.AddVertex("Arendelle");
            graph.AddVertex("Metroville");
            graph.AddVertex("Monstroplolis");
            graph.AddEdge("Pandora", "Arendelle");
            graph.AddEdge("Pandora", "Metroville");
            graph.AddEdge("Arendelle", "Monstroplolis");
            graph.AddEdge("Metroville", "Monstroplolis");

            // Act
            List<string> result = graph.BreadthFirst("Pandora");

            // Assert
            Assert.Equal(new List<string> { "Pandora", "Arendelle", "Metroville", "Monstroplolis" }, result);
        }

        [Fact]
        public void BreadthFirst_EmptyList()
        {
            // Arrange
            Graph graph = new Graph();

            // Act
            List<string> result = graph.BreadthFirst("test");

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void BusinessTrip_ValidDirectFlights_ShouldReturnTotalCost()
        {
            // Arrange
            Graph graph = new Graph();
            graph.AddVertex("Arendelle");
            graph.AddVertex("New Monstropolis");
            graph.AddVertex("Naboo");
            graph.AddEdge("Arendelle", "New Monstropolis", 42);
            graph.AddEdge("New Monstropolis", "Naboo", 73);

            string[] trip = new string[] { "Arendelle", "New Monstropolis", "Naboo" };

            // Act
            int? cost = graph.BusinessTrip(graph, trip);

            // Assert
            Assert.Equal(115, cost);
        }
        [Fact]
        public void BusinessTrip_SingleCity_ShouldReturnNull()
        {
            // Arrange
            Graph graph = new Graph();
            graph.AddVertex("Arendelle");

            string[] trip = new string[] { "Arendelle" };

            // Act
            int? cost = graph.BusinessTrip(graph, trip);

            // Assert
            Assert.Null(cost);
        }

		

		[Fact]
		public void DepthFirstFromStartNode()
		{
			// Arrange
			Graph graph = new Graph();
			graph.AddVertex("A");
			graph.AddVertex("B");
			graph.AddVertex("C");

			// Act
			List<string> traversalOrder = graph.DepthFirst("B");

			// Assert
			Assert.Equal("B", traversalOrder[0]);
		}



	}
}