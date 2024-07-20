using challenges_and_data_structures.Data_Structures.LinkedList;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list1 = new LinkedList();
            list1.Add(1);
            list1.Add(3);
            list1.Add(5);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(4);
            list2.Add(6);

            Console.WriteLine("List 1:");
            list1.PrintList();

            Console.WriteLine("List 2:");
            list2.PrintList();

            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);
            Console.WriteLine("Merged List:");
            mergedList.PrintList();

            Console.ReadKey();
        }
   
    }
}
