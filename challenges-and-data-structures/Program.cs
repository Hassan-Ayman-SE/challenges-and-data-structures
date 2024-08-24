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
            Btree.Root = new TNode(5);
            Btree.Root.Left = new TNode(13);
            Btree.Root.Right = new TNode(7);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(12);
            Btree.Root.Right.Right = new TNode(20);
            Btree.Root.Left.Left.Left = new TNode(1);
            Btree.Root.Left.Left.Right = new TNode(4);
            Btree.Root.Right.Left.Right = new TNode(11);

            List<int> largestValues = Btree.LargestValueEachLevel();

            Console.WriteLine("Largest values at each level:");
            foreach (int value in largestValues)
            {
                Console.WriteLine(value);
            }
            Console.ReadKey();

        }

    }
}
