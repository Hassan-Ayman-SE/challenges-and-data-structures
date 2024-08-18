using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class SecondMaxValueBTTests
    {
        [Fact]
        public void FindSecondMax_ShouldReturnSecondMaxValue()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(10);
            Btree.Root.Left = new TNode(5);
            Btree.Root.Right = new TNode(20);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(15);
            Btree.Root.Right.Right = new TNode(25);

            // Act
            int secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Equal(20, secondMax);
        }

        [Fact]
        public void FindSecondMax_WithSingleValueTree_ShouldThrowException()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(10);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        [Fact]
        public void FindSecondMax_WithDuplicateValues_ShouldThrowException()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(20);
            Btree.Root.Left = new TNode(20);
            Btree.Root.Right = new TNode(20);

            // Act & Assert
            Assert.Throws<InvalidOperationException>(() => Btree.FindSecondMax());
        }

        [Fact]
        public void FindSecondMax_WithNegativeValues_ShouldReturnSecondMaxValue()
        {
            // Arrange
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(-10);
            Btree.Root.Left = new TNode(-20);
            Btree.Root.Right = new TNode(-30);
            Btree.Root.Left.Right = new TNode(-15);

            // Act
            int secondMax = Btree.FindSecondMax();

            // Assert
            Assert.Equal(-15, secondMax);
        }
    }
}
