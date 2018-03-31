using System;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Can Peek()
        {
            Node node = new Node() {ValueTuple = 4};
            Node node = new Node() {ValueTuple = 8};
            Node node = new Node() {ValueTuple = 15};
            Node node = new Node() {ValueTuple = 16};
            Node node = new Node() {ValueTuple = 23};

            Stack stack = new Stack(node);
            stack.Push(node2);
        }
    }
}
