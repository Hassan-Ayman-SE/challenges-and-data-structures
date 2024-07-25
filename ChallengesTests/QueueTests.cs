using challenges_and_data_structures.Data_Structures.StackAndQueue.Queue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class QueueTests
    {
        [Fact]
        public void TestEnqueue()
        {
            // Arrange
            Queue queue = new Queue();

            // Act
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Assert
            Assert.Equal(1, queue.Peek()); // Check the front element is 1
        }

        [Fact]
        public void TestDequeue()
        {
            // Arrange
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            // Act
            int dequeuedValue = queue.Dequeue();

            // Assert
            Assert.Equal(1, dequeuedValue); // Check the correct element is dequeued
            Assert.Equal(2, queue.Peek());  // Check the front element is now 2
        }

        [Fact]
        public void TestIsEmpty()
        {
            // Arrange
            Queue queue = new Queue();

            // Act & Assert
            Assert.True(queue.IsEmpty()); // Queue should be empty initially

            queue.Enqueue(1);

            Assert.False(queue.IsEmpty()); // Queue should not be empty after enqueue

            queue.Dequeue();

            Assert.True(queue.IsEmpty()); // Queue should be empty after dequeueing all elements
        }
    }
}
