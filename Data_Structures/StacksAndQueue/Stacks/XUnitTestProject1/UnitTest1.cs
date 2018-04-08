using System;
using Xunit;
using Stacks;

namespace XUnitTestProject1
{
    public class UnitTest1
        //ARRAGE
        //ACT
        //ASSERT
    {
        /* Parts of this code base is attributed to Kevin Farrow */
        private const string V = "11";
        private const int V1 = 10;


        [Fact]
        public void stack()
        {
            Stack sample = new Stack(new Node() { Value = V1 });
            Assert.Equal("10", sample.Peek().Value.ToString());
        }


        //Adding push
        [Fact]
        public void CanPush()
        {
            Stack sample = new Stack(new Node() { Value = 11 });
            sample.Push(new Node() { Value = 10 });
            Assert.Equal("10", sample.Pop().Value.ToString());
        }

        //pop off stack
        [Fact]
        public void pop()
        {
            Stack sample = new Stack(new Node() { Value = V1 });
            sample.Push(new Node() { Value = 11 });
            sample.Push(new Node() { Value = 11 });
            Assert.Equal("11", sample.Pop().Value.ToString());

        }

        //testing adding 
        [Fact]
        public void EnqueTest()
        {
            Queue tesqueue = new Queue(new Node() { Value = V1 });
            tesqueue.Enqueue(new Node() { Value = 8 });
            Assert.Equal("10", tesqueue.Peek().Value.ToString());
        }
      // queue take away test
        [Fact]
        public void CanDequeue()
        { 
            Queue testQueue = new Queue(new Node() { Value = 5 });
            testQueue.Enqueue(new Node() { Value = 8 });
            Assert.Equal("5", testQueue.Dequeue().Value.ToString());
        }

        // Queue take away test
        [Fact]
        public void CanDequetwo()
        {
            Queue sampleQueue = new Queue(new Node() { Value = V1 });
            sampleQueue.Enqueue(new Node() { Value = 9 });
            Assert.Equal("10", sampleQueue.Dequeue().Value.ToString());
        }

    }
}
