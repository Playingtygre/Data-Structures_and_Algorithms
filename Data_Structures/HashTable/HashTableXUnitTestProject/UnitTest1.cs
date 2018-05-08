using System;
using Xunit;
using HashTable;

namespace HashTableXUnitTestProject
{
    public class UnitTest1
    {
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
    }
}
