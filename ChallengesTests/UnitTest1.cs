using challenges_and_data_structures;

namespace ChallengesTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_CommonElements_Case1()
        {
            int[] array1 = { 1, 2, 3, 0 };
            int[] array2 = { 2, 3, 4, 9 };
            int[] expected = { 2, 3 };

            int[] result = Program.CommonElements(array1, array2);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Test_CommonElements_Case2()
        {
            int[] array1 = { 79, 8, 15 };
            int[] array2 = { 23, 79, 8 };
            int[] expected = { 79, 8 };

            int[] result = Program.CommonElements(array1, array2);

            Assert.Equal(expected, result);
        }

    }
}