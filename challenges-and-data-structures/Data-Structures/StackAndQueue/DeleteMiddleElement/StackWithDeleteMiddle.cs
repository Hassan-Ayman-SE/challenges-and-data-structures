using challenges_and_data_structures.Data_Structures.StackAndQueue;
namespace challenges_and_data_structures.Data_Structures.StackAndQueue.DeleteMiddleElement
{
    using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;
    public class StackWithDeleteMiddle : Stack
    {
        public void DeleteMiddle()
        {
            if (IsEmpty()) return;

            int size = GetSize();
            int middle = size % 2 == 0 ? size / 2 - 1 : size / 2;

            Stack tempStack = new Stack();

            // Remove elements until --> reach the middle.
            for (int i = 0; i < middle; i++)
            {
                tempStack.Push(Pop());
            }

            // Remove the middle element
            Pop();

            // Push the elements back to the original stack.
            while (!tempStack.IsEmpty())
            {
                Push(tempStack.Pop());
            }
        }

        private int GetSize()
        {
            int size = 0;
            Node? current = top;
            while (current != null)
            {
                size++;
                current = current.Next;
            }
            return size;
        }

        public override string ToString()
        {
            Node? current = top;
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
