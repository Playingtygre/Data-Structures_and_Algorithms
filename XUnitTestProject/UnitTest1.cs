using System;
using Xunit;
using static Insertion_Sort.Program;

namespace XUnitTestProject
{
    public class UnitTest1
    {
        
        [Fact]
        public void SortArrayOne()
        {
            int[] testArray = new int[3] { 100, 50, 80 };

            testArray = InsertionSort(testArray);

            Assert.Equal(50, testArray[0]);
            Assert.Equal(80, testArray[1]);
            Assert.Equal(100, testArray[2]);
        }


        [Fact]
        public void SortArrayTwo()
        {
            int[] testArray = new int[3] { 100, 50, 80,  };

            testArray = InsertionSort(testArray);

            Assert.Equal(50, testArray[0]);
            Assert.Equal(80, testArray[1]);
            Assert.Equal(100, testArray[2]);
        }

        [Fact]
        public void SortArrayThree()
        {
            int[] testArray = new int[3] { 100, 50, 80 };

            testArray = InsertionSort(testArray);

            Assert.Equal(50, testArray[0]);
            Assert.Equal(80, testArray[1]);
            Assert.Equal(100, testArray[2]);
        }





        /*
        [Fact]
        public void PrintArray()
        {
            int[] testArray = new int[2] { 1, 2 };

            testArray = NewMethod(testArray);

        }*/



    }
}
