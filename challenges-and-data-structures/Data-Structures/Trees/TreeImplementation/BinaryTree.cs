﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.Trees.TreeImplementation
{
    public class BinaryTree
    {
        public TNode Root { get; set; }
        private int? max;
        private int? secondMax;


        public void PreOrder(TNode node)
        {
            if (node == null) return;
            Console.Write(node.Data + " ");
            PreOrder(node.Left);
            PreOrder(node.Right);
        }

        public void InOrder(TNode node)
        {
            if (node == null) return;
            InOrder(node.Left);
            Console.Write(node.Data + " ");
            InOrder(node.Right);
        }

        public void PostOrder(TNode node)
        {
            if (node == null) return;
            PostOrder(node.Left);
            PostOrder(node.Right);
            Console.Write(node.Data + " ");
        }


        //Second Max
        public int FindSecondMax()
        {
            if (Root == null) {
                throw new InvalidOperationException("Tree is empty.");
            } 

            Traverse(Root);

            if (secondMax == null) {
                throw new InvalidOperationException("No second maximum value.");
            }

            return secondMax.Value;
        }

        public void Traverse(TNode node)
        {
            if (node == null) return;

            if (max == null || node.Data > max)
            {
                secondMax = max;
                max = node.Data;
            }
            else if ((secondMax == null || node.Data > secondMax) && node.Data != max)
            {
                secondMax = node.Data;
            }

            Traverse(node.Left);
            Traverse(node.Right);
        }

        // Sum of leaf nodes
        public int SumOfLeafNodes()
        {
            return SumLeafNodes(Root);
        }

        private int SumLeafNodes(TNode node)
        {
            if (node == null) return 0;
            if (node.Left == null && node.Right == null) return node.Data;
            return SumLeafNodes(node.Left) + SumLeafNodes(node.Right);
        }

        // Binary Tree - Largest Value at Each Level
        public List<int> LargestValueEachLevel()
        {
            List<int> result = new List<int>();
            if (Root == null)
                return result;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                int maxVal = int.MinValue;

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    maxVal = Math.Max(maxVal, currentNode.Data);

                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }
                result.Add(maxVal);
            }
            return result;
        }

        //Binary Tree - Print Right View
        public void PrintRightView()
        {
            if (Root == null) return;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                TNode lastNode = null;

                for (int i = 0; i < levelSize; i++)
                {
                    lastNode = queue.Dequeue();
                    if (lastNode.Left != null) queue.Enqueue(lastNode.Left);
                    if (lastNode.Right != null) queue.Enqueue(lastNode.Right);
                }

                Console.Write(lastNode.Data + " ");
            }
        }

        // Binary Tree - Level with Maximum Number of Nodes
        public int FindMaxLevelNodes()
        {
            if (Root == null) return -1;

            Queue<TNode> queue = new Queue<TNode>();
            queue.Enqueue(Root);

            int maxLevel = 0;
            int maxNodes = 0;
            int currentLevel = 0;

            while (queue.Count > 0)
            {
                int levelSize = queue.Count;
                if (levelSize > maxNodes)
                {
                    maxNodes = levelSize;
                    maxLevel = currentLevel;
                }

                for (int i = 0; i < levelSize; i++)
                {
                    TNode currentNode = queue.Dequeue();
                    if (currentNode.Left != null) queue.Enqueue(currentNode.Left);
                    if (currentNode.Right != null) queue.Enqueue(currentNode.Right);
                }

                currentLevel++;
            }

            return maxLevel;
        }

        // Binary Tree - Minimum Depth
        public int FindMinimumDepth()
        {
            if (Root == null) return 0;

            Queue<(TNode, int)> queue = new Queue<(TNode, int)>();
            queue.Enqueue((Root, 1));

            while (queue.Count > 0)
            {
                var (node, depth) = queue.Dequeue();

                if (node.Left == null && node.Right == null)
                    return depth;

                if (node.Left != null)
                    queue.Enqueue((node.Left, depth + 1));

                if (node.Right != null)
                    queue.Enqueue((node.Right, depth + 1));
            }

            return 0;
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
