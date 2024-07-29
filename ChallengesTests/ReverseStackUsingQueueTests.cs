using challenges_and_data_structures.Data_Structures.StackAndQueue.ReverseStackUsingQueue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengesTests
{
    public class ReverseStackUsingQueueTests
    {
        [Fact]
        public void TestReverseStack_MultipleElements()
        {
            var stack = new StackWithReverse();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
            Assert.Equal(2, stack.Pop());
            Assert.Equal(3, stack.Pop());
            Assert.Equal(4, stack.Pop());
            Assert.Equal(5, stack.Pop());
        }

        [Fact]
        public void TestReverseStack_SingleElement()
        {
            var stack = new StackWithReverse();
            stack.Push(1);

            stack.ReverseStack();

            Assert.Equal(1, stack.Pop());
        }

        [Fact]
        public void TestReverseStack_EmptyStack()
        {
            var stack = new StackWithReverse();

            stack.ReverseStack();

            Assert.True(stack.IsEmpty());
        }

    }
}
