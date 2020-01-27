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

        [TestMethod]
        public void CheckAddListOperatorOverlaod()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> itemsTwo = new CustomList<int>();
            CustomList<int> added;
            string expected = "135246";

            //Act
            items.Add(1);
            items.Add(3);
            items.Add(5);
            itemsTwo.Add(2);
            itemsTwo.Add(4);
            itemsTwo.Add(6);
            added = items + itemsTwo;
            string actual = added.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckAddListTogetherForDifferentSizeListsTest()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> itemsTwo = new CustomList<int>();
            CustomList<int> added;
            string expected = "135555246";

            //Act
            items.Add(1);
            items.Add(3);
            items.Add(5);
            items.Add(5);
            items.Add(5);
            items.Add(5);
            itemsTwo.Add(2);
            itemsTwo.Add(4);
            itemsTwo.Add(6);
            added = items + itemsTwo;
            string actual = added.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckAddListTogetherIfTheListsAttemptedToAddAreEmpty()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> itemsTwo = new CustomList<int>();
            CustomList<int> added;
            string expected = "135555";

            //Act
            items.Add(1);
            items.Add(3);
            items.Add(5);
            items.Add(5);
            items.Add(5);
            items.Add(5);
            added = items + itemsTwo;
            string actual = added.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMinusListOperatorOverload()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> itemsTwo = new CustomList<int>();
            CustomList<int> minused;
            string expected = "3";

            //Act
            items.Add(1);
            items.Add(2);
            items.Add(3);
            itemsTwo.Add(1);
            itemsTwo.Add(2);
            itemsTwo.Add(4);
            minused = items - itemsTwo;
            string actual = minused.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMinusListOperatorOverloadForStrings()
        {
            //Arrange
            CustomList<string> items = new CustomList<string>();
            CustomList<string> itemsTwo = new CustomList<string>();
            CustomList<string> minused;
            string expected = "3";

            //Act
            items.Add("1");
            items.Add("2");
            items.Add("3");
            itemsTwo.Add("1");
            itemsTwo.Add("2");
            itemsTwo.Add("4");
            minused = items - itemsTwo;
            string actual = minused.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMinusListForFirstListAllTheSameItem()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> itemsTwo = new CustomList<int>();
            CustomList<int> minused;
            string expected = "11";

            //Act
            items.Add(1);
            items.Add(1);
            items.Add(1);
            itemsTwo.Add(2);
            itemsTwo.Add(1);
            itemsTwo.Add(4);
            minused = items - itemsTwo;
            string actual = minused.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMinusListForDifferentSizedLists()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> itemsTwo = new CustomList<int>();
            CustomList<int> minused;
            string expected = "23";

            //Act
            items.Add(1);
            items.Add(2);
            items.Add(3);
            itemsTwo.Add(1);
            itemsTwo.Add(5);
            itemsTwo.Add(4);
            itemsTwo.Add(4);
            itemsTwo.Add(4);
            minused = items - itemsTwo;
            string actual = minused.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckMinusListForDifferentSizedListsAndFirstListWillAllBeRemoved()
        {
            //Arrange
            CustomList<int> items = new CustomList<int>();
            CustomList<int> itemsTwo = new CustomList<int>();
            CustomList<int> minused;
            string expected = "";

            //Act
            items.Add(1);
            items.Add(2);
            items.Add(3);
            itemsTwo.Add(1);
            itemsTwo.Add(2);
            itemsTwo.Add(4);
            itemsTwo.Add(3);
            itemsTwo.Add(4);
            minused = items - itemsTwo;
            string actual = minused.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipTest()
        {
            //Arrange
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            CustomList<int> zipped;
            string expected = "123456";

            //Act
            first.Add(1);
            first.Add(3);
            first.Add(5);
            second.Add(2);
            second.Add(4);
            second.Add(6);
            zipped = first.Zip(second);
            string actual = zipped.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipListsFirstListIsLargerTest()
        {
            //Arrange
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            CustomList<int> zipped;
            string expected = "12345679";

            //Act
            first.Add(1);
            first.Add(3);
            first.Add(5);
            first.Add(7);
            first.Add(9);
            second.Add(2);
            second.Add(4);
            second.Add(6);
            zipped = first.Zip(second);
            string actual = zipped.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipListsSecondListIsLargerTest()
        {
            //Arrange
            CustomList<int> first = new CustomList<int>();
            CustomList<int> second = new CustomList<int>();
            CustomList<int> zipped;
            string expected = "123456810";

            //Act
            first.Add(1);
            first.Add(3);
            first.Add(5);
            second.Add(2);
            second.Add(4);
            second.Add(6);
            second.Add(8);
            second.Add(10);
            zipped = first.Zip(second);
            string actual = zipped.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipListsWithStringsTest()
        {
            //Arrange
            CustomList<string> first = new CustomList<string>();
            CustomList<string> second = new CustomList<string>();
            CustomList<string> zipped;
            string expected = "123456810";

            //Act
            first.Add("1");
            first.Add("3");
            first.Add("5");
            second.Add("2");
            second.Add("4");
            second.Add("6");
            second.Add("8");
            second.Add("10");
            zipped = first.Zip(second);
            string actual = zipped.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ZipWhenAListEmptyTest()
        {
            //Arrange
            CustomList<string> first = new CustomList<string>();
            CustomList<string> second = new CustomList<string>();
            CustomList<string> zipped;
            string expected = "abc";

            //Act
            first.Add("a");
            first.Add("b");
            first.Add("c");

            zipped = first.Zip(second);
            string actual = zipped.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void IEnumerableTest()
        //{
        //    //Arrange
        //    CustomList<int> numbers = new CustomList<int>() { 1, 2, 3 };
        //    int expected = 3;

        //    //Act 
        //    int actual = numbers[2];

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void ListIterableTest()
        //{
        //    //Arrange
        //    CustomList<int> nums = new CustomList<int>();
        //    int expected = 10;
        //    int actual;

        //    //Act
        //    nums.Add(1);
        //    nums.Add(4);
        //    nums.Add(5);
        //    int total = 0;

        //    foreach (int item in nums)
        //    {
        //        total += item;
        //    }

        //    actual = total;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void ListSortTest()
        //{
        //    //Arrange
        //    CustomList<int> numbers = new CustomList<int>();
        //    string expected = "123456789";

        //    //Act
        //    numbers.Add(3);
        //    numbers.Add(1);
        //    numbers.Add(4);
        //    numbers.Add(2);
        //    numbers.Add(6);
        //    numbers.Add(5);
        //    numbers.Add(9);
        //    numbers.Add(7);
        //    numbers.Add(8);

        //    string actual = numbers.Sort().ToString();

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void ListOfStringSortTest()
        //{
        //    //Arrange
        //    CustomList<string> stringList = new CustomList<string>();
        //    string expected = "alligatorboycatdog";

        //    //Act
        //    stringList.Add("boy");
        //    stringList.Add("alligator");
        //    stringList.Add("dog");
        //    stringList.Add("cat");
        //    string actual = stringList.StringSort().ToString();

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}
    }


}
