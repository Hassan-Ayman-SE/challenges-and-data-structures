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
            BinaryTree Btree1 = new BinaryTree();
            Btree1.Root = new TNode(1);
            Btree1.Root.Left = new TNode(2);
            Btree1.Root.Right = new TNode(3);
            Btree1.Root.Left.Left = new TNode(4);
            Btree1.Root.Left.Right = new TNode(5);

            int minDepth1 = Btree1.FindMinimumDepth();
            Console.WriteLine("Minimum Depth of Tree 1: " + minDepth1);  // Output: 2

            Console.WriteLine("==============================================");

            // Example 2: Tree with equal depth paths
            BinaryTree Btree2 = new BinaryTree();
            Btree2.Root = new TNode(1);
            Btree2.Root.Left = new TNode(2);
            Btree2.Root.Right = new TNode(3);
            Btree2.Root.Left.Right = new TNode(5);
            Btree2.Root.Right.Right = new TNode(6);

            int minDepth2 = Btree2.FindMinimumDepth();
            Console.WriteLine("Minimum Depth of Tree 2: " + minDepth2);  // Output: 3



            Console.ReadKey();

        }

    }
}
