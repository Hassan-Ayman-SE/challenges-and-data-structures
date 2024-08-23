using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class SumOfLeafNodesTests
    {
        [Fact]
        public void TestSumOfLeafNodes_PositiveValues()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(9);
            tree.Root.Left = new TNode(8);
            tree.Root.Right = new TNode(12);
            tree.Root.Left.Left = new TNode(3);
            tree.Root.Left.Right = new TNode(7);
            tree.Root.Right.Left = new TNode(17);
            tree.Root.Right.Right = new TNode(23);
            tree.Root.Left.Left.Right = new TNode(4);

            // Act
            int leafSum = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(51, leafSum);
        }

        [Fact]
        public void TestSumOfLeafNodes_NegativeValues()
        {
            // Arrange
            var tree = new BinaryTree();
            tree.Root = new TNode(-10);
            tree.Root.Left = new TNode(-20);
            tree.Root.Right = new TNode(-30);
            tree.Root.Left.Left = new TNode(-40);
            tree.Root.Left.Right = new TNode(-50);
            tree.Root.Right.Left = new TNode(-60);
            tree.Root.Right.Right = new TNode(-70);
            tree.Root.Left.Left.Right = new TNode(-80);

            // Act
            int leafSum = tree.SumOfLeafNodes();

            // Assert
            Assert.Equal(-260, leafSum);
        }
    }
}
