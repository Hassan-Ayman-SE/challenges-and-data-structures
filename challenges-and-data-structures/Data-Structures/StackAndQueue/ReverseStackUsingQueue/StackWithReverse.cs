using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace challenges_and_data_structures.Data_Structures.StackAndQueue.ReverseStackUsingQueue
{
    using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;
    using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
    using Node = Stack.Node;

    public class StackWithReverse : Stack
    {
        public void ReverseStack()
        {
            if (IsEmpty()) return;

            Queue queue = new Queue();

            // Pop elements from stack and enqueue them to the queue
            while (!IsEmpty())
            {
                queue.Enqueue(Pop());
            }

            // Dequeue elements from queue and push them back to the stack
            while (!queue.IsEmpty())
            {
                Push(queue.Dequeue());
            }


        }

        public override string ToString()
        {
            Node current = top;
            string result = "Stack: Top -> ";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            result += "null";
            return result;
        }
    }
}
