﻿namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using Xunit;

    [Collection("IConstIterator<T>.Tests")]
    public class IConstIterator_1_Tests
    {
        [Fact]
        public void Test_IConstIterator_1_Is_Interface()
        {
            typeof(IConstIterator<>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IConstIterator_1_Is_Generic()
        {
            typeof(IConstIterator<>).ContainsGenericParameters.Should().BeTrue();
            typeof(IConstIterator<int>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(1);
        }
    }
}
