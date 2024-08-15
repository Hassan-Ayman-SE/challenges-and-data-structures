using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Trees.MirrorTree
{
    public class BinaryTreeMirror
    {
        public TNode Root;

        // Inorder Traversal (Left, Root, Right)
        public List<int> InorderTraversal()
        {
            List<int> result = new List<int>();
            InorderHelper(Root, result);
            return result;
        }
        private void InorderHelper(TNode node, List<int> result)
        {
            if (node == null) return;

            InorderHelper(node.Left, result);
            result.Add(node.Data);
            InorderHelper(node.Right, result);
        }
        // Mirror the Binary Tree
        public void MirrorTree()
        {
            MirrorHelper(Root);
        }
        private void MirrorHelper(TNode node)
        {
            if (node == null) return;

            // Swap the left and right children
            TNode temp = node.Left;
            node.Left = node.Right;
            node.Right = temp;

            // Recur for left and right subtrees
            MirrorHelper(node.Left);
            MirrorHelper(node.Right);
        }
    }
}
