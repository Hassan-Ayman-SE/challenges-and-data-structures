namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Example 1
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };
            int[] result1 = CommonElements(array1, array2);
            Console.WriteLine("Array 1 elements: " + string.Join(", ", array1));
            Console.WriteLine("Array 2 elements: " + string.Join(", ", array2));
            Console.WriteLine("Common elements: " + string.Join(", ", result1));
            Console.WriteLine("=================================================");
            // Example 2
            array1 = new int[] { 79, 8, 15 };
            array2 = new int[] { 23, 79, 8 };
            int[] result2 = CommonElements(array1, array2);
            Console.WriteLine("Array 1 elements: " + string.Join(", ", array1));
            Console.WriteLine("Array 2 elements: " + string.Join(", ", array2));
            Console.WriteLine("Common elements: " + string.Join(", ", result2));
            Console.WriteLine("=================================================");

            // Example 3
            array1 = new int[] { 5, 10, 15, 20 };
            array2 = new int[] { 10, 15, 25 };
            int[] result3 = CommonElements(array1, array2);
            Console.WriteLine("Array 1 elements: " + string.Join(", ", array1));
            Console.WriteLine("Array 2 elements: " + string.Join(", ", array2));
            Console.WriteLine("Common elements: " + string.Join(", ", result3));

            Console.ReadKey();
        }
        public static int[] CommonElements(int[] array1, int[] array2)
        {
            HashSet<int> set1 = new HashSet<int>();
            List<int> commonElements = new List<int>();

            // Add all elements of array1 to the hash set
            for (int i = 0; i < array1.Length; i++)
            {
                set1.Add(array1[i]);
            }

            // Check Elements in array2 if it exists in the hash set
            for (int j = 0; j < array2.Length; j++)
            {
                if (set1.Contains(array2[j]))
                {
                    // Check if the element is already in the commonElements
                    // list to avoid duplicates (else add element to commonElements list)

                    if (!commonElements.Contains(array2[j]))
                    {
                        commonElements.Add(array2[j]);
                    }
                }
            }

            return commonElements.ToArray();
        }
    }
}
