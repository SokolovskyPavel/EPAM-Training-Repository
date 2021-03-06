﻿using System;
using System.Linq;
using NET.W._2018.Соколовский._05.Comparers;
using NUnit.Framework;

namespace NET.W._2018.Соколовский._05.Tests
{
    [TestFixture]
    public class BubbleSortingTests
    {
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_ValidDataSumFuncAscendingFalse(params int[][] args)
        {
            BubbleSorting.BubbleSort(args, new SumComparer());
            var result = new int[][] { new int[] { 5, 7, 4, 12 }, new int[] { 3, 4 }, new int[] { 3, 2, 1 } };
            CollectionAssert.AreEqual(args, result);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_ValidDataSumFuncAscendingTrue(params int[][] args)
        {
            BubbleSorting.BubbleSort(args, new SumComparer(true));
            var result = new int[][] { new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 } };
            CollectionAssert.AreEqual(args, result);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_ValidDataMaxFuncAscendingFalse(params int[][] args)
        {
            BubbleSorting.BubbleSort(args, new MaxComparer());
            var result = new int[][] { new int[] { 5, 7, 4, 12 }, new int[] { 3, 4 }, new int[] { 3, 2, 1 } };
            CollectionAssert.AreEqual(args, result);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_ValidDataMaxFuncAscendingTrue(params int[][] args)
        {
            BubbleSorting.BubbleSort(args, new MaxComparer(true));
            var result = new int[][] { new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 } };
            CollectionAssert.AreEqual(args, result);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_ValidDataMinFuncAscendingFalse(params int[][] args)
        {
            BubbleSorting.BubbleSort(args, new MinComparer());
            var result = new int[][] { new int[] { 5, 7, 4, 12 }, new int[] { 3, 4 }, new int[] { 3, 2, 1 } };
            CollectionAssert.AreEqual(args, result);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_ValidDataMinFuncAscendingTrue(params int[][] args)
        {
            BubbleSorting.BubbleSort(args, new MinComparer(true));
            var result = new int[][] { new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 } };
            CollectionAssert.AreEqual(args, result);
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_NullArray_ArgumentNullException(params int[][] args)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSorting.BubbleSort(null, new MinComparer(true)));
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, new int[] { 5, 7, 4, 12 })]
        public void BubbleSorting_NullFunction_ArgumentNullException(params int[][] args)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSorting.BubbleSort(args, null));
        }

        [TestCase(new int[] { 3, 2, 1 }, new int[] { 3, 4 }, null)]
        public void BubbleSorting_OneOfTheArrayNull_ArgumentNullException(params int[][] args)
        {
            Assert.Throws<ArgumentNullException>(() => BubbleSorting.BubbleSort(args, new MinComparer(true)));
        }
    }
}