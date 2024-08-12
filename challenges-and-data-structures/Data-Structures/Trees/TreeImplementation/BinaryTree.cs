using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Trees.TreeImplementation
{
    public class BinaryTree
    {
        public TNode Root { get; set; }

        public void PreOrder(TNode node, Action<int> captureOutput)
        {
            if (node == null) return;
            Console.Write(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(TNode node, Action<int> captureOutput)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        public void PostOrder(TNode node, Action<int> captureOutput)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }

        public void Print(TNode node, string indent = "", bool isLeft = true)
        {
            if (node == null)
            {
                Console.WriteLine($"{indent}*");
                return;
            }

            Console.WriteLine($"{indent}{(isLeft ? "├──" : "└──")}{node.Data}");
            indent += isLeft ? "│   " : "    ";
            Print(node.Left, indent, true);
            Print(node.Right, indent, false);
        }
    }
}
