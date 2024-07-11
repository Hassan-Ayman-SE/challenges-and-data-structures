using challenges_and_data_structures;
using challenges_and_data_structures.Data_Structures.LinkedList;
using Microsoft.VisualStudio.TestPlatform.ObjectModel.Utilities;

namespace ChallengesTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test_RemoveNodeFromEnd()
        {
            // Arrange: Setting up the linked list with initial values
           
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Act: Removing the node with value 20
            list.Remove(20);

            // Assert: Verifying that the node with value 20 is no longer in the list
            Assert.False(list.Includes(20));
        }

        [Fact]
        public void Test_PrintList()
        {
            // Arrange: Setting up the linked list with initial values
            LinkedList list = new LinkedList();
            list.Add(5);
            list.Add(10);
            list.Add(20);

            // Act: Capturing the printed output of the list
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                list.PrintList();
                var result = sw.ToString().Trim();

                // Assert: Verifying that the printed output matches the expected format
                Assert.Equal("Head -> 5 -> 10 -> 20 -> Null", result);
            }
        }

    }
}