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
            Btree.Root = new TNode(10);
            Btree.Root.Left = new TNode(5);
            Btree.Root.Right = new TNode(20);
            Btree.Root.Left.Left = new TNode(3);
            Btree.Root.Left.Right = new TNode(7);
            Btree.Root.Right.Left = new TNode(15);
            Btree.Root.Right.Right = new TNode(25);

            Btree.Print(Btree.Root);//Print Binary Tree Elements
            int secondMax = Btree.FindSecondMax(); // Output: 20
            Console.WriteLine("Second Max In Binary Tree: " + secondMax);
            Console.ReadKey();

        }

    }
}
