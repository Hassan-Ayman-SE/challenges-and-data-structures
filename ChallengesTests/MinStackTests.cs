using challenges_and_data_structures.Data_Structures.StackAndQueue.MinStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class MinStackTests
    {
        [Fact]
        public void TestPushAndGetMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);
            Assert.Equal(3, minStack.GetMin());
        }

        [Fact]
        public void TestPopAndGetMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);
            minStack.Pop();
            Assert.Equal(7, minStack.GetMin());
        }

        [Fact]
        public void TestTop()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            Assert.Equal(7, minStack.Top());
        }

        [Fact]
        public void TestIsEmpty()
        {
            MinStack minStack = new MinStack();
            Assert.True(minStack.IsEmpty());
            minStack.Push(15);
            Assert.False(minStack.IsEmpty());
        }

        [Fact]
        public void TestPushAndPopAndGetMin()
        {
            MinStack minStack = new MinStack();
            minStack.Push(15);
            minStack.Push(7);
            minStack.Push(12);
            minStack.Push(3);
            Assert.Equal(3, minStack.GetMin());
            minStack.Pop();
            Assert.Equal(7, minStack.GetMin());
            minStack.Push(2);
            Assert.Equal(2, minStack.GetMin());
        }
    }
}
