﻿namespace RangeIt.Tests.Iterators.Adapters.NotConst
{
    using FluentAssertions;
    using RangeIt.Iterators;
    using Traits;
    using Xunit;

    [Category("Iterators.Adapters.NotConst.ArrayIteratorAdapter<T>")]
    public class ArrayIteratorAdapter_1_Tests
    {
        [Fact]
        public void Test_ArrayIteratorAdapter_1_Begin_Ctor_WithEmptyArray()
        {
            var array = new int[0];
            Iterator<int> it = array.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_End_Ctor_WithEmptyArray()
        {
            var array = new int[0];
            Iterator<int> it = array.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_Begin_Iteration_WithEmptyArray()
        {
            var array = new int[0];
            Iterator<int> it = array.Begin();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_End_Iteration_WithEmptyArray()
        {
            var array = new int[0];
            Iterator<int> it = array.End();

            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_Begin_Ctor_WithNotEmptyArray()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            Iterator<int> it = array.Begin();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_End_Ctor_WithNotEmptyArray()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            Iterator<int> it = array.End();

            it.Should().NotBeNull();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_Begin_Iteration_WithNotEmptyArray()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            Iterator<int> it = array.Begin();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 1. back iteration
            it.Previous().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(array.Length);
            it.Current.Should().Be(0);

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_End_Iteration_WithNotEmptyArray()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            Iterator<int> it = array.End();

            // 1. iteration
            it.Next().Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            // 1. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 2. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 3. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 5. back iteration
            it.Previous().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 6. back iteration
            it.Previous().Should().BeFalse();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().Be(0);

            // 1. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(0);
            it.Current.Should().Be(1);

            // 2. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(1);
            it.Current.Should().Be(2);

            // 3. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(2);
            it.Current.Should().Be(3);

            // 4. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(3);
            it.Current.Should().Be(4);

            // 5. iteration
            it.Next().Should().BeTrue();
            it.Index.Should().Be(4);
            it.Current.Should().Be(5);

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(array.Length);
            it.Current.Should().Be(0);
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_Begin_Assignment()
        {
            var array = new string[] { "a", "b", "c", "d", "e" };
            Iterator<string> it = array.Begin();

            for (int i = 0; i < 3; ++i)
                it.Next();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.Current.Should().NotBeNull().And.Be("c");

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            array.Should().ContainInOrder(new string[] { "a", "b", "g", "d", "e" });
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_End_Assignment()
        {
            var array = new string[] { "a", "b", "c", "d", "e" };
            Iterator<string> it = array.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            array.Should().ContainInOrder(new string[] { "a", "b", "c", "d", "e" });
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_Begin_Assignment_IndexOutOfBound()
        {
            var array = new string[] { "a", "b", "c", "d", "e" };
            Iterator<string> it = array.Begin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.Current.Should().BeNull();

            it.Current = "g";
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            array.Should().ContainInOrder(new string[] { "a", "b", "c", "d", "e" });
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_Begin_IsValid()
        {
            var array = new string[] { "a", "b", "c", "d", "e" };
            Iterator<string> it = array.Begin();

            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();

            // 1. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(0);
            it.IsValid.Should().BeTrue();

            // 2. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(1);
            it.IsValid.Should().BeTrue();

            // 3. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(2);
            it.IsValid.Should().BeTrue();

            // 4. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(3);
            it.IsValid.Should().BeTrue();

            // 5. iteration
            it.Next().Should().BeTrue();
            it.IsEndIterator.Should().BeFalse();
            it.Index.Should().Be(4);
            it.IsValid.Should().BeTrue();

            // 6. iteration
            it.Next().Should().BeFalse();
            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(5);
            it.IsValid.Should().BeFalse();
        }

        [Fact]
        public void Test_ArrayIteratorAdapter_1_End_IsValid()
        {
            var array = new string[] { "a", "b", "c", "d", "e" };
            Iterator<string> it = array.End();

            it.IsEndIterator.Should().BeTrue();
            it.Index.Should().Be(-1);
            it.IsValid.Should().BeFalse();
        }
    }
}
