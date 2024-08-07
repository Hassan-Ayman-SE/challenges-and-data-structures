using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.StackAndQueue.MinStack
{
    public class MinStack
    {
        private Stack<int> stack;
        private Stack<int> minStack;//for minimum elements

        public MinStack()
        {
            stack = new Stack<int>();
            minStack = new Stack<int>();
        }

        public void Push(int data)
        {
            stack.Push(data);
            if (minStack.Count == 0 || data <= minStack.Peek())
            {
                minStack.Push(data);
            }
        }

        public int Pop()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            int top = stack.Pop();
            if (top == minStack.Peek())
            {
                minStack.Pop();
            }
            return top;
        }

        public int Top()
        {
            if (stack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return stack.Peek();
        }

        public bool IsEmpty()
        {
            return stack.Count == 0;
        }

        public int GetMin()
        {
            if (minStack.Count == 0)
                throw new InvalidOperationException("Stack is empty");

            return minStack.Peek();
        }

        public void PrintStack()
        {
            Console.WriteLine("Stack: Top -> " + string.Join(" -> ", stack.ToArray()));
        }
    }

}
