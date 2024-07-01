namespace challenges_and_data_structures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int[] array = { 15, 17, 12, 19, 13, 11, 16 };
            int maximumValue = MaximumValue(array);
            Console.WriteLine("Array elements: " + string.Join(", ", array));
            Console.WriteLine("The Maximum value is: " + maximumValue);

            Console.ReadKey();
        }

        public static int MaximumValue(int[] array)
        {
            //1- Check if the array empty or null and return -1
            if (array.Length == 0 || array == null)
            {
                return -1;
            }
            //2- Taking the first value from the array and storing it in a variable called Max,
            // assuming it is the largest value in the array
            int max = array[0];

            //3- Iterate through the array starting with second element
            for (int i = 1; i < array.Length; i++)
            {
                //4- If the this element is greater than the max value --> update max
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            return max;
        }

    }
}
