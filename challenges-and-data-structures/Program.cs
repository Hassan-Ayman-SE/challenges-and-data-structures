namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //int[] array = { 1, 2, 3, 4, 5 };
            //int[] reversedArray = ArrayReversal(array);

            //Console.WriteLine("Array Before Reverse: " + string.Join(", ", array));
            //Console.WriteLine("Array After Reverse: " + string.Join(", ", reversedArray));

            // Challenge B: Most Frequent Number
            int[] array = { 1, 1, 2, 2, 3, 4, 5, 5, 5, 6 };
            int mostFrequentNumber = FindMostFrequentNumber(array);
            Console.WriteLine("Most frequent number: " + mostFrequentNumber);
            Console.ReadKey();
        }


        //Challange A: Array Reversal
        public static int[] ArrayReversal(int[] array)
        {
            //get the length of the array
            int arrLength = array.Length;
            //create a reversed array with the same length of original array.
            int[] reversedArray = new int[arrLength];

            //for loop to store numbers in reversedArray
            for (int i = 0; i < arrLength; i++)
            {
                reversedArray[i] = array[arrLength - i - 1];
            }

            return reversedArray;
        }


        // Challenge B: Most Frequent Number
        public static int FindMostFrequentNumber(int[] array)
        {
            // Use dictionary to store number counts
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            // Count each number how many times it occurs in the array 
            foreach (int number in array)
            {
                if (numberCounts.ContainsKey(number))
                {
                    // If number already exists in the dictionary increment its count
                    numberCounts[number]++;
                }
                else
                {
                    // If number does not exist in the dictionary add it with initial count 1
                    numberCounts[number] = 1;
                }
            }
            int mostFrequentNumber = array[0];
            int maxCount = 1;
            // Find number with the maximum count
            foreach (var item in numberCounts)
            {
                if (item.Value > maxCount)
                {
                    // If current count is higher than the previous maxCount
                    // update mostFrequentNumber and maxCount
                    mostFrequentNumber = item.Key;
                    maxCount = item.Value;
                }
            }
            // Return the most frequent number
            return mostFrequentNumber;
        }


    }
}
