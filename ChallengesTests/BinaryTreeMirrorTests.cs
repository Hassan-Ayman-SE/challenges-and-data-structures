using challenges_and_data_structures.Data_Structures.Trees.MirrorTree;
using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class BinaryTreeMirrorTests
    {
        [Fact]
        public void Test_MirrorTree_InorderTraversal()
        {
            BinaryTreeMirror Btree = new BinaryTreeMirror();
            Btree.Root = new TNode(4);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(12);
            Btree.Root.Left.Right = new TNode(9);

            List<int> originalInorder = Btree.InorderTraversal(); // Expected: [12, 8, 9, 4, 7]
            Assert.Equal(new List<int> { 12, 8, 9, 4, 7 }, originalInorder);

            Btree.MirrorTree();

            List<int> mirroredInorder = Btree.InorderTraversal(); // Expected: [7, 4, 9, 8, 12]
            Assert.Equal(new List<int> { 7, 4, 9, 8, 12 }, mirroredInorder);
        }

        [Fact]
        public void Test_MirrorTree_SingleNodeTree()
        {
            BinaryTreeMirror Btree = new BinaryTreeMirror();
            Btree.Root = new TNode(1);

            List<int> inorderBeforeMirror = Btree.InorderTraversal(); // Expected: [1]
            Assert.Equal(new List<int> { 1 }, inorderBeforeMirror);

            Btree.MirrorTree();

            List<int> inorderAfterMirror = Btree.InorderTraversal(); // Expected: [1]
            Assert.Equal(new List<int> { 1 }, inorderAfterMirror);
        }

        [Fact]
        public void Test_MirrorTree_EmptyTree()
        {
            BinaryTreeMirror Btree = new BinaryTreeMirror();

            List<int> inorderBeforeMirror = Btree.InorderTraversal(); // Expected: []
            Assert.Empty(inorderBeforeMirror);

            Btree.MirrorTree();

            List<int> inorderAfterMirror = Btree.InorderTraversal(); // Expected: []
            Assert.Empty(inorderAfterMirror);
        }

    }
}
