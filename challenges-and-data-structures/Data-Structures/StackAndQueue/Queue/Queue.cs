using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.StackAndQueue.Queue
{
    public class Queue
    {
        private Node? front;
        private Node? rear;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (rear != null) rear.Next = newNode;
            rear = newNode;
            if (front == null) front = newNode;
        }

        public int Dequeue()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            int data = front.Data;
            front = front.Next;
            if (front == null) rear = null;
            return data;
        }

        public int Peek()
        {
            if (IsEmpty()) throw new InvalidOperationException("Queue is empty");
            return front.Data;
        }

        public bool IsEmpty() => front == null;

        public void PrintQueue()
        {
            Node? current = front;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }

}
