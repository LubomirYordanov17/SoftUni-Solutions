namespace Database.Tests
{
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class DatabaseTests
    {
        private Database db;
        [SetUp]
        public void SetUp()
        {
            db = new Database();
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1})]
        [TestCase(new int[] { 1,2,3})]
        [TestCase(new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16})]
        public void ConstructorShouldAddLessThan17Elements(int[] elementsToAdd)
        {
            Database testDb=new Database(elementsToAdd);
            int[] actualData = testDb.Fetch();
            int[] expectedData = elementsToAdd;
            int actualCount=testDb.Count;
            int expectedCount=expectedData.Length;
            CollectionAssert.AreEqual(actualData, expectedData);
            Assert.AreEqual(actualCount, expectedCount);


        }
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 ,17})]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 ,17,18,19})]
        public void ConstructorMustNotBeMoreThan16Elements(int[] elementsToAdd)
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                Database testDb = new Database(elementsToAdd);

            }, "Array's capacity must be exactly 16 integers!"
            );



        }
        [Test]
        public void CountReturnTrueValue()
        {
            int acctualCount=db.Count;
            int expectedCount = 0;
            Assert.AreEqual(acctualCount, expectedCount);
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13,14,15,16 })]
        public void MethodAddShouldAdd16Elements(int[] elementsToAdd)
        {
            foreach (int el in elementsToAdd)
            {
                this.db.Add(el);
                
            }
            int[] actualData = this.db.Fetch();
            int[] expectedData = elementsToAdd;
            int actualCount = db.Count;
            int expectedCount = expectedData.Length;
            CollectionAssert.AreEqual(actualData, expectedData);
            Assert.AreEqual(actualCount, expectedCount);
        }
        [Test]
        public void MethodAddShouldntAddMoreThan16Elements()
        {
            for (int i = 1; i <= 16; i++)
            {
                this.db.Add(i);
            }
            Assert.Throws<InvalidOperationException>(() =>
            {
                this.db.Add(17);

            }, "Array's capacity must be exactly 16 integers!");
        }
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void RemoveIsWoringSuccesfully(int[] startingElements)
        {
            foreach (int el in startingElements)
            {
                this.db.Add(el);

            }
            this.db.Remove();
            List<int> elList=new List<int>(startingElements);
            elList.RemoveAt(elList.Count - 1);
            int[] actualData = this.db.Fetch();
            int[] expectedData = elList.ToArray();
            int actualCount = db.Count;
            int expectedCount = expectedData.Length;
            CollectionAssert.AreEqual(actualData, expectedData);
            Assert.AreEqual(actualCount, expectedCount);
        }
        [Test]
        public void RemoveShouldRemoveLastElementMoreThanOnce()
        {
            List<int> list = new List<int> { 1, 2, 3, };
            for (int i = 0; i <list.Count; i++)
            {
                this.db.Add(list[i]);
            }
            for (int i = 0; i < list.Count; i++)
            {
                this.db.Remove();
            }
            int[] actualData = this.db.Fetch();
            int[] expectedData = new int[] {};
            int actualCount = db.Count;
            int expectedCount = 0;
            CollectionAssert.AreEqual(actualData, expectedData);
            Assert.AreEqual(actualCount, expectedCount);
        }
        [Test]
        public void RemoveShouldNotRemoveWhenCollectionIsEmpty()
        {
            Assert.Throws<InvalidOperationException>(() =>
            this.db.Remove(),
            "The collection is empty!");
        }
        [TestCase(new int[] { })]
        [TestCase(new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 })]
        public void FetchShouldCopy(int[] init)
        {
            foreach (var el in init)
            {
                this.db.Add(el);
            }
            int[] actualData = this.db.Fetch();
            int[] expectedData = init;
            CollectionAssert.AreEqual(actualData, expectedData);
        }
    }
}
