using challenges_and_data_structures.Data_Structures.LinkedList;
using challenges_and_data_structures.Data_Structures.StackAndQueue.DeleteMiddleElement;
using challenges_and_data_structures.Data_Structures.StackAndQueue.MinStack;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.ReverseStackUsingQueue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;
using challenges_and_data_structures.Data_Structures.Trees.MirrorTree;
using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Example 1: Binary tree with multiple levels
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new TNode(1);
            tree1.Root.Left = new TNode(2);
            tree1.Root.Right = new TNode(3);
            tree1.Root.Left.Left = new TNode(4);
            tree1.Root.Left.Right = new TNode(5);
            tree1.Root.Right.Right = new TNode(6);
            tree1.Root.Left.Left.Left = new TNode(7);

            int maxLevel1 = tree1.FindMaxLevelNodes();
            Console.WriteLine("Level with maximum nodes in Tree 1: " + maxLevel1);  // Output: 2

            Console.WriteLine("======================");

            // Example 2: Binary tree where level 3 has the maximum number of nodes
            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new TNode(1);
            tree2.Root.Left = new TNode(2);
            tree2.Root.Right = new TNode(3);
            tree2.Root.Left.Left = new TNode(4);
            tree2.Root.Left.Right = new TNode(5);
            tree2.Root.Right.Right = new TNode(7);
            tree2.Root.Left.Left.Left = new TNode(8);
            tree2.Root.Left.Left.Right = new TNode(11); // Add this to increase level 3 nodes
            tree2.Root.Left.Right.Left = new TNode(9);
            tree2.Root.Right.Right.Left = new TNode(10);

            // Find the level with the maximum number of nodes
            int maxLevel2 = tree2.FindMaxLevelNodes();
            Console.WriteLine("Level with maximum nodes in Tree 2: " + maxLevel2);  // Output: 3



            Console.ReadKey();

        }

    }
}
