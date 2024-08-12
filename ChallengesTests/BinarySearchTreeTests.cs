using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class BinarySearchTreeTests
    {
        [Fact]
        public void TestAddNode()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.True(bst.Contains(10));
            Assert.True(bst.Contains(5));
            Assert.True(bst.Contains(15));
        }

        [Fact]
        public void TestContainsNode()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);

            Assert.True(bst.Contains(10));
            Assert.False(bst.Contains(7));
        }

        [Fact]
        public void TestRemoveNode()
        {
            var bst = new BinarySearchTree();
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Remove(5);

            Assert.False(bst.Contains(5));
        }
    }
}
