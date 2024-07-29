using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.ReverseStackUsingQueue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            StackWithReverse stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("Ex 1:");
            Console.WriteLine(stack); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1
            
            stack.ReverseStack();
            Console.WriteLine("After Reveresed: ");
            Console.WriteLine(stack); // Stack: Top -> 1 -> 2 -> 3 -> 4 -> 5

            stack.Push(6);
            stack.Push(7);
            Console.WriteLine("====================================================");
            Console.WriteLine("Ex 2:");
            Console.WriteLine(stack); // Stack: Top -> 7 -> 6 -> 1 -> 2 -> 3 -> 4 -> 5

            stack.ReverseStack();
            Console.WriteLine("After Reveresed: ");
            Console.WriteLine(stack); // Stack: Top -> 5 -> 4 -> 3 -> 2 -> 1 -> 6 -> 7
            Console.ReadKey();
        }
   
    }
}
