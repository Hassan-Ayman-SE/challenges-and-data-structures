using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using Xunit;

namespace ChallengesTests
{
    public class MaxLevelNodesTest
    {
        [Fact]
        public void FindMaxLevelNodes_MultipleLevels_ShouldReturnCorrectLevel()
        {
            // Example 1: Multiple levels with varying node counts
            BinaryTree tree = new BinaryTree();
            tree.Root = new TNode(1);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(3);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Left.Right = new TNode(5);
            tree.Root.Right.Right = new TNode(6);
            tree.Root.Left.Left.Left = new TNode(7);

            int maxLevel = tree.FindMaxLevelNodes();
            Assert.Equal(2, maxLevel);  // Output: 2
        }

        [Fact]
        public void FindMaxLevelNodes_SameMaxNodesOnMultipleLevels_ShouldReturnSmallestLevel()
        {
            // Example 2: Multiple levels with the same number of nodes
            BinaryTree tree = new BinaryTree();
            tree.Root = new TNode(1);
            tree.Root.Left = new TNode(2);
            tree.Root.Right = new TNode(3);
            tree.Root.Left.Left = new TNode(4);
            tree.Root.Left.Right = new TNode(5);
            tree.Root.Right.Right = new TNode(7);
            tree.Root.Left.Left.Left = new TNode(8);
            tree.Root.Left.Right.Left = new TNode(9);
            tree.Root.Right.Right.Left = new TNode(10);

            int maxLevel = tree.FindMaxLevelNodes();
            Assert.Equal(2, maxLevel);  // Output: 2 (level 2 and 3 both have 3 nodes, return the smallest)
        }

        [Fact]
        public void FindMaxLevelNodes_EmptyTree_ShouldReturnNegativeOne()
        {
            // Edge case: Empty tree
            BinaryTree tree = new BinaryTree();
            int maxLevel = tree.FindMaxLevelNodes();
            Assert.Equal(-1, maxLevel);  // Output: -1 for empty tree
        }

        [Fact]
        public void FindMaxLevelNodes_SingleNodeTree_ShouldReturnZero()
        {
            // Edge case: Tree with only one node
            BinaryTree tree = new BinaryTree();
            tree.Root = new TNode(1);
            int maxLevel = tree.FindMaxLevelNodes();
            Assert.Equal(0, maxLevel);  // Output: 0 for single node tree
        }
    }
}
