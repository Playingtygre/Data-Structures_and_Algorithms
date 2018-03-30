using System;
using Xunit;
using LinkList;

namespace XUnitTestProject1
{
    public class UnitTest1
    {

        [Theory]
        [InlineData(3)]
        

        public void Add(int value)
        {
            Node node1 = new Node();
            SinglyLinked sll = new SinglyLinked(node1);
            Assert.Equal(3, sll.AddAtEnd(value));
        }

        [Theory]
        [InlineData(4)]

        public void Addtwo(int value)
        {
            Node node1 = new Node();
            SinglyLinked sll = new SinglyLinked(node1);
            Assert.Equal(4, sll.AddAtEnd(value));
        }


        [Theory]
        [InlineData(3)]

        public void AddThree(int value)
        {
            Node node2 = new Node();
            SinglyLinked sll = new SinglyLinked(node2);
            Assert.Equal(3, sll.AddAtEnd(value));

        }

        [Theory]
        [InlineData(4)]

        public void AddFour(int value)
        {
            Node node4 = new Node();
            SinglyLinked sll = new SinglyLinked(node4);
            Assert.Equal(4, sll.AddAtEnd(value));
        }

        [Theory]
        [InlineData(5)]

        public void AddFive(int value)
        {
            Node node5 = new Node();
            SinglyLinked sll = new SinglyLinked(node5);
            Assert.Equal(5, sll.AddAtEnd(value));
        }


    }// bottom of test
}
