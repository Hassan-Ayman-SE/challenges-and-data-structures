using challenges_and_data_structures.Data_Structures.StackAndQueue.DeleteMiddleElement;
using challenges_and_data_structures.Data_Structures.StackAndQueue.MinStack;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.ReverseStackUsingQueue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;
using challenges_and_data_structures.Data_Structures.Trees.TreeImplementation;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree bst = new BinarySearchTree();

            // Add nodes to the BST
            bst.Add(10);
            bst.Add(5);
            bst.Add(15);
            bst.Add(7);

            // Display the tree
            Console.WriteLine("Binary Search Tree:");
            Console.ForegroundColor = ConsoleColor.Green;
            bst.Print(bst.Root);

            // Check if a node exists
            bool contains = bst.Contains(7); // contains: true
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Contains 7: {contains}");

            // Remove a node
            bst.Remove(5);
            Console.WriteLine("\nAfter removing 5:");
            Console.ForegroundColor = ConsoleColor.Green;
            bst.Print(bst.Root);

            // Check if the node is removed
            contains = bst.Contains(5); // contains: false
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Contains 5: {contains}");

            Console.ReadKey();

        }

    }
}
