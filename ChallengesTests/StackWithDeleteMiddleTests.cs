using challenges_and_data_structures.Data_Structures.StackAndQueue.DeleteMiddleElement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class StackWithDeleteMiddleTests
    {
        [Fact]
        public void TestDeleteMiddle_OddSizedStack()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(3);
            stack.Push(8);
            stack.Push(5); // Stack: Top -> 5 -> 8 -> 3 -> 14 -> 7

            // Act
            stack.DeleteMiddle(); // Middle element 3 should be removed

            // Assert
            Assert.Equal(5, stack.Pop());
            Assert.Equal(8, stack.Pop());
            Assert.Equal(14, stack.Pop());
            Assert.Equal(7, stack.Pop());
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestDeleteMiddle_EvenSizedStack()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(7);
            stack.Push(14);
            stack.Push(8);
            stack.Push(5); // Stack: Top -> 5 -> 8 -> 14 -> 7

            // Act
            stack.DeleteMiddle(); // Lower middle element 8 should be removed

            // Assert
            Assert.Equal(5, stack.Pop());
            Assert.Equal(14, stack.Pop());
            Assert.Equal(7, stack.Pop());
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestDeleteMiddle_SingleElementStack()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle();
            stack.Push(7); // Stack: Top -> 7

            // Act
            stack.DeleteMiddle(); // Only element 7 should be removed

            // Assert
            Assert.True(stack.IsEmpty());
        }

        [Fact]
        public void TestDeleteMiddle_EmptyStack()
        {
            // Arrange
            var stack = new StackWithDeleteMiddle(); // Stack is empty

            // Act
            stack.DeleteMiddle(); // No action should be performed

            // Assert
            Assert.True(stack.IsEmpty());
        }
    }
}
