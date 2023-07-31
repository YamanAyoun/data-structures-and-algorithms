using trees;

namespace TestTree
{
    public class UnitTest1
    {
        [Fact]
        public void EmptyTree()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            Assert.Null(tree.Root);
        }

        [Fact]
        public void TreeWithSingleRootNode()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(1);
            Assert.Equal(1, tree.Root.Value);
        }

        [Fact]
        public void AddLeftChildAndRightChildToBinarySearchTree()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);
            tree.Add(3);
            tree.Add(7);

            Assert.Equal(5, tree.Root.Value);
            
            //child
            Assert.Equal(3, tree.Root.Left.Value);
            Assert.Equal(7, tree.Root.Right.Value);
        }

        [Fact]
        public void PreOrderTraversal()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(3);
            tree.Add(1);
            tree.Add(10);
            
            

            List<int> PreOrder = new List<int> { 3, 1, 10};
            
            Assert.Equal(PreOrder, tree.PreOrderTravarsel());
        }

        [Fact]
        public void InOrderTraversal()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(3);
            tree.Add(1);
            tree.Add(10);
            

            List<int> InOrder = new List<int> { 1, 3, 10 };
  
            Assert.Equal(InOrder, tree.InorderTraversal());
        }

        [Fact]
        public void PostOrderTraversal()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(3);
            tree.Add(1);
            tree.Add(10);
            

            List<int> PostOrder = new List<int> { 1, 10, 3 };
            
            Assert.Equal(PostOrder, tree.PostorderTraversal());
        }

        [Fact]
        public void TestContains()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            tree.Add(5);
            tree.Add(10);

            Assert.True(tree.Contains(10));
            Assert.False(tree.Contains(12));
        }

        [Fact]
        public void TestFindMaximumInTree()
        {
            
            BinarySearchTree<int> tree = new BinarySearchTree<int>();

            tree.Add(2);
            tree.Add(7);
            tree.Add(5);
            tree.Add(2);
            tree.Add(6);
            tree.Add(9);
            tree.Add(11);

            Assert.Equal(11, tree.FindMaximumValue());
        }
    }
}