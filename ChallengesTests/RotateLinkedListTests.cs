using challenges_and_data_structures.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{

    using challenges_and_data_structures.Data_Structures.LinkedList;
    using Xunit;

    public class RotateLinkedListTests
    {
        [Fact]
        public void Rotate_By_Zero_Should_Not_Change_List()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);

            // Act
            list.RotateLeft(0);

            // Assert
            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", ListToString(list));
        }

        [Fact]
        public void Rotate_By_K_Should_Rotate_Correctly()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            // Act
            list.RotateLeft(2);

            // Assert
            Assert.Equal("Head -> 3 -> 4 -> 5 -> 1 -> 2 -> Null", ListToString(list));
        }

        [Fact]
        public void Rotate_By_Greater_Than_List_Length_Should_Work()
        {
            // Arrange
            LinkedList list = new LinkedList();
            list.Add(10);
            list.Add(20);
            list.Add(30);

            // Act
            list.RotateLeft(7); // k is greater than list length

            // Assert
            Assert.Equal("Head -> 20 -> 30 -> 10 -> Null", ListToString(list));
        }

        // Helper method to convert linked list to string for testing
        private string ListToString(LinkedList list)
        {
            Node current = list.head;
            string result = "Head -> ";
            while (current != null)
            {
                result += current.Data + " -> ";
                current = current.Next;
            }
            result += "Null";
            return result;
        }
    }

}
