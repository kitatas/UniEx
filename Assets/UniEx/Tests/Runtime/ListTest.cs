using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using Assert = UnityEngine.Assertions.Assert;

namespace UniEx.Tests
{
    public sealed class ListTest
    {
        [Test]
        public void GetIndex()
        {
            // Get Last Index (array)
            {
                int[] array = new int[] { 3, 5, 7, 9 };
                Assert.AreEqual(array.GetLastIndex(), 3);
            }

            // Get Last Index (list)
            {
                List<int> list = new List<int> { 3, 5, 7, 9 };
                Assert.AreEqual(list.GetLastIndex(), 3);
            }

            // Get Random Index (array)
            {
                int[] array = new int[] { 3, 5, 7, 9 };
                var index = array.GetRandomIndex();
                Assert.IsTrue(index.IsBetween(0, 3));
            }

            // Get Random Index (list)
            {
                List<int> list = new List<int> { 3, 5, 7, 9 };
                var index = list.GetRandomIndex();
                Assert.IsTrue(index.IsBetween(0, 3));
            }
        }

        [Test]
        public void IsNull()
        {
            // Is Null (array)
            {
                int[] array1 = null;
                Assert.IsTrue(array1.IsNull());

                int[] array2 = new int[] { 3, 5, 7, 9 };
                Assert.IsFalse(array2.IsNull());
            }

            // Is Null (list)
            {
                List<int> list1 = null;
                Assert.IsTrue(list1.IsNull());

                List<int> list2 = new List<int> { 3, 5, 7, 9 };
                Assert.IsFalse(list2.IsNull());
            }

            // Is Null (array index)
            {
                GameObject[] array = new GameObject[] { new GameObject(), null, new GameObject() };
                Assert.IsTrue(array.IsNull(1));
                Assert.IsFalse(array.IsNull(0));
            }

            // Is Null (list index)
            {
                List<GameObject> list = new List<GameObject> { new GameObject(), null, new GameObject() };
                Assert.IsTrue(list.IsNull(1));
                Assert.IsFalse(list.IsNull(0));
            }
        }

        [Test]
        public void IsOutOfRange()
        {
            // Is Out Of Range (array)
            {
                int[] array = new int[] { 3, 5, 7, 9 };
                Assert.IsTrue(array.IsOutOfRange(5));
                Assert.IsFalse(array.IsOutOfRange(0));
            }

            // Is Out Of Range (list)
            {
                List<int> list = new List<int> { 3, 5, 7, 9 };
                Assert.IsTrue(list.IsOutOfRange(5));
                Assert.IsFalse(list.IsOutOfRange(0));
            }
        }

        [Test]
        public void TryGetValue()
        {
            // Try Get Value (array)
            {
                int[] array = new int[] { 3, 5, 7, 9 };
                bool result1 = array.TryGetValue(0, out int value1);
                Assert.IsTrue(result1);
                Assert.AreEqual(value1, 3);

                bool result2 = array.TryGetValue(5, out int value2);
                Assert.IsFalse(result2);
                Assert.AreEqual(value2, default);
            }

            // Try Get Value (list)
            {
                List<int> list = new List<int> { 3, 5, 7, 9 };
                bool result1 = list.TryGetValue(0, out int value1);
                Assert.IsTrue(result1);
                Assert.AreEqual(value1, 3);

                bool result2 = list.TryGetValue(5, out int value2);
                Assert.IsFalse(result2);
                Assert.AreEqual(value2, default);
            }
        }
    }
}