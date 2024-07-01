namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex 1:
            int[] arr1 = { 1, 2, 3, 4 };
            int[] result1 = MiddleValue(arr1, 5);
            Console.WriteLine(string.Join(", ", result1));
            //Ex 2:
            int[] arr2 = { 10, 20, 30, 40, 50 };
            int[] result2 = MiddleValue(arr2, 25);
            Console.WriteLine(string.Join(", ", result2));
            //Ex 3:
            int[] arr3 = { 7, 14, 21, 28 };
            int[] result3 = MiddleValue(arr3, 10);
            Console.WriteLine(string.Join(", ", result3));

            Console.ReadKey();
        }

        public static int[] MiddleValue(int[] arr, int value)
        {
            int length = arr.Length;
            int[] result = new int[length + 1];
            // Calculate the middle index based on the length of the array.
            int middleIndex;
            //Even
            if (length % 2 == 0)
            {

                middleIndex = length / 2;
            }
            //Odd
            else
            {
                middleIndex = length / 2 + 1;
            }

            int j = 0;
            for (int i = 0; i <= length; i++)
            {
                // If the current index matches the middle index, assign the specified value.
                if (i == middleIndex)
                {
                    result[i] = value;
                }
                else
                {
                    // Otherwise, assign the corresponding element from the input array.
                    result[i] = arr[j++];
                }
            }

            return result;
        }


    }
}
