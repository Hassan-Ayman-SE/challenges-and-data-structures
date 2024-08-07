using challenges_and_data_structures.Data_Structures.StackAndQueue.DeleteMiddleElement;
using challenges_and_data_structures.Data_Structures.StackAndQueue.MinStack;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.ReverseStackUsingQueue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            MinStack minStack = new MinStack();

            minStack.Push(15); // Top -> 15 (min: 15)
            minStack.Push(7);  // Top -> 7 -> 15 (min: 7) 
            minStack.Push(12); // Top -> 12 -> 7 -> 15 (min: 7)
            minStack.Push(3);  // Top -> 3 -> 12 -> 7 -> 15 (min: 3) 

            minStack.PrintStack(); // Output: Top -> 3 -> 12 -> 7 -> 15

            int min = minStack.GetMin(); // min: 3
            Console.WriteLine($"Min: {min}");

            int popped = minStack.Pop(); // popped: 3
            minStack.PrintStack(); // Output: Top -> 12 -> 7 -> 15

            min = minStack.GetMin(); // min: 7
            Console.WriteLine($"Min: {min}");

            int peeked = minStack.Top(); // peeked: 12
            Console.WriteLine($"Top: {peeked}");

            minStack.Push(2);  // Top -> 2 -> 12 -> 7 -> 15 (min: 2)
            minStack.PrintStack(); // Output: Top -> 2 -> 12 -> 7 -> 15

            min = minStack.GetMin(); // min: 2
            Console.WriteLine($"Min: {min}");

            bool isEmpty = minStack.IsEmpty(); // isEmpty: false
            //Console.WriteLine($"Is Empty: {isEmpty}");
            Console.ReadKey();

        }

    }
}
