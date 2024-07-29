using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.StackAndQueue.Stack
{
    public class Stack
    {
        public Node? top;

        public Stack()
        {
            top = null;
        }

        public void Push(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            int data = top.Data;
            top = top.Next;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return top.Data;
        }

        public bool IsEmpty()
        {
            return top == null;
        }

        public void PrintStack()
        {
            Node current = top;
            Console.WriteLine("Stack contents (Top to Bottom):");
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
