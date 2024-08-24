using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class LargestValueAtEachLevelTests
    {
        [Fact]
        public void TestLargestValueEachLevel_PositiveValues()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(5);
            tree.Root.Left = new TNode(13);
            tree.Root.Right = new TNode(7);
            tree.Root.Left.Left = new TNode(3);
            tree.Root.Left.Right = new TNode(7);
            tree.Root.Right.Left = new TNode(12);
            tree.Root.Right.Right = new TNode(20);
            tree.Root.Left.Left.Left = new TNode(1);
            tree.Root.Left.Left.Right = new TNode(4);
            tree.Root.Right.Left.Right = new TNode(11);

            // Act
            List<int> largestValues = tree.LargestValueEachLevel();

            // Assert
            Assert.Equal(new List<int> { 5, 13, 20, 11 }, largestValues);
        }

        [Fact]
        public void TestLargestValueEachLevel_EmptyTree()
        {
            // Arrange
            var tree = new BinaryTree();

            // Act
            List<int> largestValues = tree.LargestValueEachLevel();

            // Assert
            Assert.Empty(largestValues);
        }

        [Fact]
        public void TestLargestValueEachLevel_SingleNode()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(42);

            // Act
            List<int> largestValues = tree.LargestValueEachLevel();

            // Assert
            Assert.Equal(new List<int> { 42 }, largestValues);
        }
    }
}
