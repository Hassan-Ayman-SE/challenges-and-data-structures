using challenges_and_data_structures.Data_Structures.StackAndQueue.Stack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class StackTests
    {
        [Fact]
        public void TestPush()
        {
            // Arrange
            var stack = new Stack();

            // Act
            stack.Push(10);

            // Assert
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void TestPop()
        {
            // Arrange
            var stack = new Stack();
            stack.Push(10);
            stack.Push(5);

            // Act
            int popped = stack.Pop();

            // Assert
            Assert.Equal(5, popped);
            Assert.Equal(10, stack.Peek());
        }

        [Fact]
        public void TestIsEmpty()
        {
            // Arrange
            var stack = new Stack();

            // Act & Assert
            Assert.True(stack.IsEmpty());

            stack.Push(10);
            Assert.False(stack.IsEmpty());
        }
    }
}
