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


        [Theory]
        [InlineData("Key1")]
        [InlineData("key2")]
        [InlineData("key3")]
        public void GetHash(string key)
        {
            //arrange
            HashTables newtable = new HashTables();
            //Act
            int hash = newtable.GetHash(key);

            //Assert
            Assert.Equal(hash, newtable.GetHash(key));
        }

        [Fact]
        public void CanCreateHashTable()
        {
            HashTables newTable = new HashTables();

            Assert.NotNull(newTable);
           
        }

        //Add [Fact] -> hash 



        /* Let us see if we can call get value method
         */

        [Theory]
        [InlineData("key1", "pair1")]
        [InlineData("key111", "pair111")]
        [InlineData("key121", "pair121")]
        public void CanAdd(string key, string value)
        {
            //Arrange
            HashTables testTable = new HashTables();
            //Act
            testTable.Add(key, value);
            //Assert
            Assert.Equal(value, testTable.Contain(key));
        }






    }
}
