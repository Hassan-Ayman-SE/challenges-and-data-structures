using challenges_and_data_structures.Data_Structures.LinkedList;

namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            // Add nodes to the list
            list.Add(5);
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Print the list
            Console.WriteLine("Original list:");
            list.PrintList(); // Output: Head -> 5 -> 10 -> 20 -> 30 -> Null

            // Remove a node from the list
            Console.WriteLine("Removing node with value 10:");
            list.Remove(10);
            list.PrintList(); // Output: Head -> 5 -> 20 -> 30 -> Null

            // Check if the list includes a certain value
            Console.WriteLine("Checking if the list includes value 20:");
            bool includes20 = list.Includes(20);
            Console.WriteLine(includes20); // Output: True

            Console.WriteLine("Checking if the list includes value 10:");
            bool includes10 = list.Includes(10);
            Console.WriteLine(includes10); // Output: False
            Console.ReadKey();
        }
   
    }
}
