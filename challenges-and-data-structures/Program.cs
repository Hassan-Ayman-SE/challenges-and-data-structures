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

            // Example 1 
            BinaryTree tree1 = new BinaryTree();
            tree1.Root = new TNode(2);
            tree1.Root.Left = new TNode(3);
            tree1.Root.Right = new TNode(5);
            tree1.Root.Left.Left = new TNode(4);
            tree1.Root.Right.Right = new TNode(6);
            tree1.Root.Left.Left.Right = new TNode(7);

            Console.WriteLine("Right View of Tree 1:");
            tree1.PrintRightView();  // Output: 2 5 6 7
            Console.WriteLine();

            Console.WriteLine("======================");

            // Example 2 
            BinaryTree tree2 = new BinaryTree();
            tree2.Root = new TNode(1);
            tree2.Root.Right = new TNode(2);
            tree2.Root.Right.Right = new TNode(3);
            tree2.Root.Right.Right.Right = new TNode(4);

            Console.WriteLine("Right View of Tree 2:");
            tree2.PrintRightView();  // Output: 1 2 3 4
            Console.WriteLine();
            
                 
           
            Console.ReadKey();

        }

    }
}
