using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Trees.TreeImplementation
{
    public class BinarySearchTree : BinaryTree
    {
        public void Add(int data)
        {
            Root = AddRecursive(Root, data);
        }

        private TNode AddRecursive(TNode node, int data)
        {
            if (node == null)
            {
                return new TNode(data);
            }

            if (data < node.Data)
            {
                node.Left = AddRecursive(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = AddRecursive(node.Right, data);
            }

            return node;
        }

        public bool Contains(int data)
        {
            return ContainsRecursive(Root, data);
        }

        private bool ContainsRecursive(TNode node, int data)
        {
            if (node == null)
            {
                return false;
            }

            if (data == node.Data)
            {
                return true;
            }

            return data < node.Data ? ContainsRecursive(node.Left, data) : ContainsRecursive(node.Right, data);
        }

        public void Remove(int data)
        {
            Root = RemoveRecursive(Root, data);
        }

        private TNode RemoveRecursive(TNode node, int data)
        {
            if (node == null) return null;

            if (data < node.Data)
            {
                node.Left = RemoveRecursive(node.Left, data);
            }
            else if (data > node.Data)
            {
                node.Right = RemoveRecursive(node.Right, data);
            }
            else
            {
                if (node.Left == null) return node.Right;
                if (node.Right == null) return node.Left;

                node.Data = MinValue(node.Right);
                node.Right = RemoveRecursive(node.Right, node.Data);
            }

            return node;
        }

        private int MinValue(TNode node)
        {
            int minv = node.Data;
            while (node.Left != null)
            {
                minv = node.Left.Data;
                node = node.Left;
            }
            return minv;
        }
    }
}
