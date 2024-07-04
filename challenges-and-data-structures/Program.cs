namespace challenges_and_data_structures
{
    public class Program
    {
        static void Main(string[] args)
        {
            var example1 = "csharp is programming language";
            var example2 = "Reverse the words in this sentence";
            var example3 = "challenges and data structures";

            Console.WriteLine($"Input: \"{example1}\"");
            Console.WriteLine($"Output: \"{ReverseWords(example1)}\"");
            Console.WriteLine();
            Console.WriteLine($"Input: \"{example2}\"");
            Console.WriteLine($"Output: \"{ReverseWords(example2)}\"");
            Console.WriteLine();
            Console.WriteLine($"Input: \"{example3}\"");
            Console.WriteLine($"Output: \"{ReverseWords(example3)}\"");
            Console.WriteLine();
            Console.ReadKey();
        }
        public static string ReverseWords(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return input;
            }

            var words = input.Split(' ');
            Array.Reverse(words);
            return string.Join(" ", words);
        }

    }
}
