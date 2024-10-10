using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class MinimumDepthTests
    {
        [Fact]
        public void TestTreeWithMultipleNodes()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Left = new TNode(4);
            Btree.Root.Left.Right = new TNode(5);

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(2, minDepth);
        }

        [Fact]
        public void TestTreeWithEqualDepthPaths()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(1);
            Btree.Root.Left = new TNode(2);
            Btree.Root.Right = new TNode(3);
            Btree.Root.Left.Right = new TNode(5);
            Btree.Root.Right.Right = new TNode(6);

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(3, minDepth);
        }

        [Fact]
        public void TestEmptyTree()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();

            // Act
            int minDepth = Btree.FindMinimumDepth();

            // Assert
            Assert.Equal(0, minDepth);
        }
    }
}
