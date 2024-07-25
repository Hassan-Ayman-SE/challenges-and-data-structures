using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;
            //====================STACK====================
            //Stack stack = new Stack();

            //// Push nodes onto the stack
            //stack.Push(10);
            //Console.WriteLine("Pushed 10"); // Stack: Top -> 10

            //stack.Push(5);
            //Console.WriteLine("Pushed 5"); // Stack: Top -> 5 -> 10

            //// Pop a node from the stack
            //int popped = stack.Pop();
            //Console.WriteLine($"Popped: {popped}"); // popped: 5, Stack: Top -> 10

            //// Peek the top node
            //int peeked = stack.Peek();
            //Console.WriteLine($"Peeked: {peeked}"); // peeked: 10

            //// Check if the stack is empty
            //bool isEmpty = stack.IsEmpty();
            //Console.WriteLine($"Is stack empty? {isEmpty}"); // isEmpty: false
            //stack.PrintStack();

            //using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
            //====================Queue====================
            Queue queue = new Queue();

            // Enqueue elements
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            // Print the queue
            Console.WriteLine("Queue contents:"); // Output: 10 20 30
            queue.PrintQueue();

            // Peek the front element
            Console.WriteLine($"Front element: {queue.Peek()}"); // Output: Front element: 10

            // Dequeue elements
            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Output: Dequeued: 10
            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Output: Dequeued: 20

            // Check if queue is empty
            Console.WriteLine($"Is queue empty? {queue.IsEmpty()}"); // Output: Is queue empty? False

            // Peek and Dequeue the last element
            Console.WriteLine($"Front element: {queue.Peek()}"); // Output: Front element: 30
            Console.WriteLine($"Dequeued: {queue.Dequeue()}"); // Output: Dequeued: 30

            // Final check if the queue is empty
            Console.WriteLine($"Is queue empty? {queue.IsEmpty()}"); // Output: Is queue empty? True

            Console.ReadKey();
        }
   
    }
}
