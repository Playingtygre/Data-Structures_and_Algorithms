using System;
using Xunit;
using HashTable;

namespace HashTableXUnitTestProject
{
    public class UnitTest1
    {
        /* Let us check to see if we call get hash method
         */

        [Theory]
        [InlineData("key1")]
        [InlineData("key2")]
        [InlineData("key3")]
        public void CanHash(string testValue)
        {
            //Arrange
            HashTables testTable = new HashTables();
            //Act
            int hash = testTable.GetHash(testValue);
            //Assert
            Assert.Equal(hash, testTable.GetHash(testValue));
        }



        /* Let us see if we can call get value method
         */

        [Theory]
        [InlineData("Key1", "pair1")]
        [InlineData("key2", "pair2")]
        [InlineData("key3", "pair3")]
        public void CanAdd(string key, string value)
        {
            //Arrange
            HashTables testTable = new HashTables();
            //Act
            testTable.Add(key, value);
            //Assert
            Assert.Equal(value, testTable.Contains(key, value));
        }

    }
}
