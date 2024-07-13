using challenges_and_data_structures.Data_Structures.LinkedList;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // Add nodes to the list
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.Add(7);
            list.Add(7);

            // Print the list
            Console.WriteLine("Original list:");
            list.PrintList(); 

            // Remove duplicates
            Console.WriteLine("Removing duplicates:");
            list.RemoveDuplicate();
            list.PrintList(); 
            Console.ReadKey();
        }
   
    }
}
