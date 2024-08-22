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
            BinaryTree Btree = new BinaryTree();
            Btree.Root = new TNode(9);
            Btree.Root.Left = new TNode(8);
            Btree.Root.Right = new TNode(12);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(17);
            Btree.Root.Right.Right = new TNode(23);
            Btree.Root.Left.Left.Right = new TNode(4);

            int leafSum = Btree.SumOfLeafNodes(); // Output: 51
            Console.WriteLine("Sum Of Leaf Nodes is: " + leafSum);
            Console.ReadKey();

        }

    }
}
