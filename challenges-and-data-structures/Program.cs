namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] input1 = { 1, 2, 3, 1, 2, 3 };
            int[] result1 = FindDuplicates(input1);
            Console.WriteLine(string.Join(", ", result1));  //Expected Output: 1, 2, 3

            //Ex 2:
            int[] input2 = { 16, 8, 31, 17, 15, 23, 17, 8 };
            int[] result2 = FindDuplicates(input2);
            Console.WriteLine(string.Join(", ", result2));  //Expected Output: 17, 8

            //Ex 3:
            int[] input3 = { 5, 10, 16, 20, 10, 16 };
            int[] result3 = FindDuplicates(input3);
            Console.WriteLine(string.Join(", ", result3));  //Expected Output: 10, 16


            Console.ReadKey();
        }

        public static int[] FindDuplicates(int[] arr)
        {
            // Create a dictionary to store the frequency of each number.
            Dictionary<int, int> frequencyNumbers = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                frequencyNumbers[num] = frequencyNumbers.ContainsKey(num) ? frequencyNumbers[num] + 1 : 1;
            }

            // Create a list to store the duplicate values.
            List<int> duplicatesNunberList = new List<int>();

            // Add the elements with frequency greater than 1 to the duplicates list.
            foreach (KeyValuePair<int, int> kvp in frequencyNumbers)
            {
                if (kvp.Value > 1)
                {
                    duplicatesNunberList.Add(kvp.Key);
                }
            }

            // Convert the list to an array and return the result.
            return duplicatesNunberList.ToArray();
        }

    }
}
