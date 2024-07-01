namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 10, 9, 41, 5, 17 };
            int[] array2 = { 7, 9, 13, 25, 5, 17 };
            Console.WriteLine("Array Before Deletion " + string.Join(", ", array1));
            Console.WriteLine("Array After Deletion " + string.Join(", ", RemoveMiddleValue(array1))); // Output: 1, 2, 4, 5
            Console.WriteLine("====================================================");
            Console.WriteLine("Array Before Deletion " + string.Join(", ", array2));
            Console.WriteLine("Array After Deletion " + string.Join(", ", RemoveMiddleValue(array2))); // Output: 1, 2, 4, 5

            Console.ReadKey();
        }


        public static int[] RemoveMiddleValue(int[] arr)
        {
            int length = arr.Length;
            // If the array is empty, return it as is.
            if (length == 0)
                return arr;
            // Get the length of the new array after deletion.
            int newLength = (length % 2 == 0) ? length - 2 : length - 1;
            int[] newArray = new int[newLength];
            // Get the two middle index in the array.
            int middleIndex1 = (length / 2) - 1;
            int middleIndex2 = length / 2;
            //index for the newArray
            int j = 0;
            for (int i = 0; i < length; i++)
            {
                if (length % 2 == 0)
                {
                    // The length is even ---> skip the two middle elements.
                    if (i == middleIndex1 || i == middleIndex2) continue;
                }
                else
                {
                    // The length is odd ---> skip the single middle element.
                    if (i == middleIndex2) continue;
                }
                newArray[j++] = arr[i];
            }

            return newArray;
        }


    }
}
