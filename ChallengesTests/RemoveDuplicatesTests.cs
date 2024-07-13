using challenges_and_data_structures.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class RemoveDuplicatesTests
    {

        [Fact]
        public void Test_NoDuplicates()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            list.RemoveDuplicate();

            // Assert
            string result = CaptureOutput(list.PrintList);
            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", result);
        }

        [Fact]
        public void Test_WithDuplicates()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(2);
            list.Add(3);

            // Act
            list.RemoveDuplicate();

            // Assert
            string result = CaptureOutput(list.PrintList);
            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", result);
        }

        [Fact]
        public void Test_AllDuplicates()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(1);
            list.Add(1);

            // Act
            list.RemoveDuplicate();

            // Assert
            string result = CaptureOutput(list.PrintList);
            Assert.Equal("Head -> 1 -> Null", result);
        }

        private string CaptureOutput(Action action)
        {
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                action();
                return sw.ToString().Trim();
            }
        }
    }
}
