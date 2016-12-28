﻿namespace RangeIt.Tests.Iterators.Interfaces
{
    using FluentAssertions;
    using RangeIt.Iterators.Interfaces;
    using System.Collections.Generic;
    using Xunit;

    [Collection("IIterator<T, U>.Tests")]
    public class IIterator_2_Tests
    {
        [Fact]
        public void Test_IIterator_2_Is_Interface()
        {
            typeof(IIterator<,>).IsInterface.Should().BeTrue();
        }

        [Fact]
        public void Test_IIterator_2_Is_Generic()
        {
            typeof(IIterator<,>).ContainsGenericParameters.Should().BeTrue();
            typeof(IIterator<int, float>).GenericTypeArguments.Should().NotBeEmpty().And.HaveCount(2);
        }

        [Fact]
        public void Test_IIterator_2_DerivesFrom_IIterable_Interface()
        {
            typeof(IIterator<,>).GetInterfaces().Should().Contain(typeof(IIterable));
        }

        [Fact]
        public void Test_IIterator_2_DerivesFrom_IEnumerable_1_Interface()
        {
            typeof(IIterator<int, float>).GetInterfaces().Should().Contain(typeof(IEnumerable<KeyValuePair<int, float>>));
        }
    }
}