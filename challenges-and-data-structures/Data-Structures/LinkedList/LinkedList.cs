using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenges_and_data_structures.Data_Structures.LinkedList
{
    public class LinkedList
    {
        public Node? head;

        public LinkedList()
        {
            head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        public bool Includes(int data)
        {
            Node? current = head;
            while (current != null)
            {
                if (current.Data == data)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }

        public void Remove(int data)
        {
            if (head == null) return;

            if (head.Data == data)
            {
                head = head.Next;
                return;
            }

            Node? current = head;
            Node? previous = null;

            while (current != null && current.Data != data)
            {
                previous = current;
                current = current.Next;
            }

            if (current == null) return;

            previous.Next = current.Next;
        }

        //ADD RemoveDuplicate() Method
        public void RemoveDuplicate()
        {
            Node current = head;
            while (current != null && current.Next != null)
            {
                Node index = current;
                while (index.Next != null)
                {
                    if (current.Data == index.Next.Data)
                    {
                        index.Next = index.Next.Next;
                    }
                    else
                    {
                        index = index.Next;
                    }
                }
                current = current.Next;
            }
        }

        //RotateLinkedList
        public void RotateLeft(int k)
        {
            //Base case: rotation is needed
            if (head == null || k == 0) return;

            Node current = head;
            int length = 1;
            //find the length of linked list
            while (current.Next != null)
            {
                length++;
                current = current.Next;
            }

            k = k % length;
            if (k == 0) return;

            current.Next = head; // Connect tail to head (make it circular)
            current = head;

            //move to the (k-1)th node which will become the new tail
            for (int i = 1; i < k; i++)
            {
                current = current.Next;
            }

            head = current.Next;
            current.Next = null; // Break the loop
        }

        public static LinkedList MergeSortedLists(LinkedList list1, LinkedList list2)
        {
            LinkedList mergedList = new LinkedList();
            Node? current1 = list1.head;
            Node? current2 = list2.head;

            while (current1 != null && current2 != null)
            {
                if (current1.Data < current2.Data)
                {
                    mergedList.Add(current1.Data);
                    current1 = current1.Next;
                }
                else
                {
                    mergedList.Add(current2.Data);
                    current2 = current2.Next;
                }
            }

            while (current1 != null)
            {
                mergedList.Add(current1.Data);
                current1 = current1.Next;
            }

            while (current2 != null)
            {
                mergedList.Add(current2.Data);
                current2 = current2.Next;
            }

            return mergedList;
        }


        public void PrintList()
        {
            Node? current = head;
            Console.Write("Head -> ");
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("Null");
        }
    }
}
