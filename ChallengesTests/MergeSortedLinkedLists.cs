using challenges_and_data_structures.Data_Structures.LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class MergeSortedLinkedLists
    {
        [Fact]
        public void Merge_WhenOneListIsEmpty_ReturnsNonEmptyList()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 1 -> 2 -> 3 -> Null", mergedList.ToString());
        }

        [Fact]
        public void Merge_WhenBothListsAreEmpty_ReturnsEmptyList()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> Null", mergedList.ToString());
        }

        [Fact]
        public void Merge_List1AndList2FromExample_ReturnsMergedList()
        {
            // Arrange
            LinkedList list1 = new LinkedList();
            list1.Add(5);
            list1.Add(10);
            list1.Add(15);

            LinkedList list2 = new LinkedList();
            list2.Add(2);
            list2.Add(3);
            list2.Add(20);

            // Act
            LinkedList mergedList = LinkedList.MergeSortedLists(list1, list2);

            // Assert
            Assert.Equal("Head -> 2 -> 3 -> 5 -> 10 -> 15 -> 20 -> Null", mergedList.ToString());
        }
    }
}
