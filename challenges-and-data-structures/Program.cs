using challenges_and_data_structures.Data_Structures.StackAndQueue.DeleteMiddleElement;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.ReverseStackUsingQueue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackWithDeleteMiddle stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5);

            Console.WriteLine(stack); // Output: Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7
            Console.WriteLine("After Deleted Middle Element: ");
            stack.DeleteMiddle();
            Console.WriteLine(stack); // Output: Stack: Top -> 5 -> 8 -> 14 -> 7

            Console.WriteLine("=====================================================");
            Console.WriteLine("Ex2:");

            
            stack.Push(9);
            stack.Push(11);
            Console.WriteLine(stack); // Output: Stack: Top -> 11 -> 9 -> 2 -> 5 -> 8 -> 14 -> 7
            Console.WriteLine("After Deleted Middle Element: ");
            stack.DeleteMiddle();
            Console.WriteLine(stack); // Output: Stack: Top -> 11 -> 9 -> 2 -> 8 -> 14 -> 7
            Console.ReadKey();

        }

    }
}
