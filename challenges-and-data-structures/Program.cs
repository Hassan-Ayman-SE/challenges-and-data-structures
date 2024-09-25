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

            // Example 1: Rotate by 2
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            Console.WriteLine("Original list 1:");
            list1.PrintList();
            list1.RotateLeft(2);
            Console.WriteLine("After rotating by 2:");
            list1.PrintList();
            Console.WriteLine("=================================================");
            // Example 2: Rotate by 3
            LinkedList list2 = new LinkedList();
            list2.Add(10);
            list2.Add(20);
            list2.Add(30);
            list2.Add(40);
            list2.Add(50);
            Console.WriteLine("Original list 2:");
            list2.PrintList();
            list2.RotateLeft(3);
            Console.WriteLine("After rotating by 3:");
            list2.PrintList();
            Console.WriteLine("=================================================");
            // Example 3: Rotate by 1
            LinkedList list3 = new LinkedList();
            list3.Add(5);
            list3.Add(10);
            list3.Add(15);
            list3.Add(20);
            Console.WriteLine("Original list 3:");
            list3.PrintList();
            list3.RotateLeft(1);
            Console.WriteLine("After rotating by 1:");
            list3.PrintList();
            Console.ReadKey();

        }

    }
}
