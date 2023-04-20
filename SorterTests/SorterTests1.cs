using NUnit.Framework;
using SorterAlgorithm;
using SorterWebAPI;

namespace SorterTests
{
    public class IntSorterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new int[] { 1, 11, 2, 3, 1, 222, 2, 1, 22, 3, 4, 0, 3 }, new int[] { 0, 1, 1, 1, 2, 2, 3, 3, 3, 4, 11, 22, 222 })] //Test With Repeated Entities
        [TestCase(new int[] { -3, 4, -7, 8, 3, 44, -12 }, new int[] { -12, -7, -3, 3, 4, 8, 44 })] //Test With Negatives
        [TestCase(new int[] { 4, 1, 2, 3, 5, 6, 22, 12, 11, 13, 15, 17, 14, 19, 29, 37, 33, 9, 0 }, new int[] { 0, 1, 2, 3, 4, 5, 6, 9, 11, 12, 13, 14, 15, 17, 19, 22, 29, 33, 37 })] //UnNcessary Test
        public void IntTest1(int[] inputArray, int[] expected)
        {
            //Arrange
            //Since Sorter class is static there is nothing to arrange
            #region
            //int[] inputArray = new int[] { 4, 1, 2, 3, 5, 6, 22, 12, 11, 13, 15, 17, 14, 19, 29, 37, 33, 9, 0 };
            //int[] expected = new int[] { 0, 1, 2, 3, 4, 5, 6, 9, 11, 12, 13, 14, 15, 17, 19, 22, 29, 33, 37 };
            #endregion

            //Act
            int[] actual = Sorter.IntSort(inputArray);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
    public class CharSorterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new char[] { 'c', 't', 'z', 'a', 'd', 'b' }, new char[] { 'a', 'b', 'c', 'd', 't', 'z' })]
        [TestCase(new char[] { 'A', 'c', 'b', 'B', 'R', 'D', 'd' }, new char[] { 'A', 'B', 'b', 'c', 'D', 'd', 'R' })] //Test with CAPITAL letters
        public void CharTest(char[] inputArray, char[] expected)
        {
            //Arrange

            //Act
            char[] actual = Sorter.CharSort(inputArray);
            //Assert

            Assert.AreEqual(expected, actual);

        }



    }

    public class DoubleSorterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase(new double[] { 1.1, 1.11, 2.1, 3.3, 1.7, 22.3, 9, 2, 1, 22.39, 3.0, 4.0, 4.0, 3 }, new double[] { 1, 1.1, 1.11, 1.7, 2, 2.1, 3, 3, 3.3, 4, 4, 9, 22.3, 22.39 })] //Test With Repeated Entities
        [TestCase(new double[] { -3.5, 4.4, -7.0, 8.34, -12.2, 3, 44.2023, -12.1 }, new double[] { -12.2, -12.1, -7.0, -3.5, 3, 4.4, 8.34, 44.2023 })] //Test With Negative numbers
        public void DoubleTest(double[] inputArray, double[] expected)
        {
            //Arrange

            //Act
            double[] actual = Sorter.DoubleSort(inputArray);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }

    public class StringSorterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("StringsAreExtra-Ordinary", "-AaadEegiinnOrrrrrSsttxy")]
        [TestCase("Strings Are Extra-Ordinary", "-AaadEegiinnOrrrrrSsttxy")] //Test with spaces(will not pass)
        public void StringTest(string input ,string expected)
        {
            //Arrange

            //Act
            string actual = Sorter.StringSort(input);

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }



}