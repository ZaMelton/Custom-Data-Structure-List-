using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomListBuild;

namespace CustomListBuildTest
{
    [TestClass]
    public class CustomListTest
    {
        [TestMethod]
        public void AddTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int expected = 1;

            //Act
            items.Add(value);
            int actual = items[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckAddForAddingTwoItems()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int expected = 3;

            //Act
            items.Add(value);
            items.Add(secondValue);
            int actual = items[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddFifthItemTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expected = 9;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            items.Add(fifthValue);
            int actual = items[4];

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void CheckOrderAfterAddFifthElementTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expected = 3;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            items.Add(fifthValue);
            int actual = items[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckCountWhenEmptyTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int expected = 0;

            //Act
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckCountAfterAddOneItemTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 5;
            int expected = 1;

            //Act
            items.Add(value);
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void CheckCountAfterAddThreeItemsTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 5;
            int secondValue = 8;
            int thirdValue = 12;
            int expected = 3;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckCountAfterAddFiveItemsTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expected = 5;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            items.Add(fifthValue);
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DefaultCapacityTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int expected = 4;

            //Act
            items.Add(value);
            items.Add(secondValue);
            int actual = items.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AfterAddFifthItemCapacityTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expected = 8;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            items.Add(fifthValue);
            int actual = items.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RemoveOneItemTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int expected = 5;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Remove(secondValue);
            int actual = items[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForRemoveItemThatDoesntExist()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int expected = 3;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Remove(4);
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void CheckOrderAfterRemoveTwoItemTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expected = 9;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            items.Add(fifthValue);
            items.Remove(secondValue);
            items.Remove(fourthValue);
            int actual = items[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckCapacityAfterRemovingFifthElementTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            int fourthValue = 7;
            int fifthValue = 9;
            int expected = 8;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            items.Add(fifthValue);
            items.Remove(fifthValue);
            int actual = items.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckForRemovingOnlySpecifiedElementWhenThereAreMultiplesTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 1;
            int thirdValue = 1;
            int fourthValue = 1;
            int fifthValue = 1;
            int expected = 4;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            items.Add(fifthValue);
            items.Remove(thirdValue);
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckCountAfterRemoveTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 5;
            int secondValue = 7;
            int expected = 1;

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Remove(secondValue);
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTestForItemsThatAreNotStrings()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            int value = 1;
            int secondValue = 3;
            int thirdValue = 5;
            string expected = "135";

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            string actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringTestIfItemsAreStrings()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            string value = "Look";
            string secondValue = "It's";
            string thirdValue = "A";
            string fourthValue = "String";
            string expected = "LookIt'sAString";

            //Act
            items.Add(value);
            items.Add(secondValue);
            items.Add(thirdValue);
            items.Add(fourthValue);
            string actual = items.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToStringIfListIsEmptyTest()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            string expected = "";

            //Act
            string actual = items.ToString(); ;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void CheckAddListTogether()
        //{
        //    //Arrange
        //    CustomList<int> items = new CustomList<int>();
        //    CustomList<int> itemsTwo = new CustomList<int>();
        //    CustomList<int> added = new CustomList<int>();
        //    string expectedResult = "135246";

        //    //Act
        //    items.Add(1);
        //    items.Add(3);
        //    items.Add(5);
        //    itemsTwo.Add(2);
        //    itemsTwo.Add(4);
        //    itemsTwo.Add(6);
        //    added.Add(items[0]);
        //    added.Add(items[1]);
        //    added.Add(items[2]);
        //    added.Add(itemsTwo[0]);
        //    added.Add(itemsTwo[1]);
        //    added.Add(itemsTwo[2]);

        //    //Assert
        //    Assert.AreEqual(expectedResult, added.ToString());
        //}

        //[TestMethod]
        //public void ZipTest()
        //{
        //    //Arrange
        //    CustomList<int> odd = new CustomList<int>();
        //    CustomList<int> even = new CustomList<int>();
        //    CustomList<int> zipped = new CustomList<int>();
        //    string expectedResult = "123456";

        //    //Act
        //    odd.Add(1);
        //    odd.Add(3);
        //    odd.Add(5);
        //    even.Add(2);
        //    even.Add(4);
        //    even.Add(6);
        //    zipped.Add(odd[0]);
        //    zipped.Add(even[0]);
        //    zipped.Add(odd[1]);
        //    zipped.Add(even[1]);
        //    zipped.Add(odd[2]);
        //    zipped.Add(even[2]);

        //    //Assert
        //    Assert.AreEqual(expectedResult, zipped.ToString());
        //}
    }
}
