﻿namespace Iterator.Performance.Tests.Const
{
    using BenchmarkDotNet.Attributes;
    using BenchmarkDotNet.Attributes.Columns;
    using RangeIt.Iterators;
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    [MinColumn, MaxColumn]
    public class ReadOnlyDictionary_2_ConstIterator_Vs_Enumerator_Tests
    {
        private readonly Dictionary<int, int> _dictionaryInts = new Dictionary<int, int>();
        private readonly Dictionary<string, string> _dictionaryStrings = new Dictionary<string, string>();

        private ReadOnlyDictionary<int, int> _readOnlyDictionaryInts;
        private ReadOnlyDictionary<string, string> _readOnlyDictionaryStrings;

        private ConstIterator<int, int> _itInt;
        private ConstIterator<int, int> _itIntOp;
        private ConstIterator<string, string> _itString;
        private ConstIterator<string, string> _itStringOp;

        [GlobalSetup]
        public void Setup()
        {
            var rnd = new Random();
            const int max = Constants.MAX_ITEMS;

            for (int i = 0; i < max; i++)
                _dictionaryInts[i] = rnd.Next(max);

            for (int i = 0; i < max; i++)
                _dictionaryStrings[i.ToString()] = rnd.Next(max).ToString();

            _readOnlyDictionaryInts = new ReadOnlyDictionary<int, int>(_dictionaryInts);
            _readOnlyDictionaryStrings = new ReadOnlyDictionary<string, string>(_dictionaryStrings);

            _itInt = _readOnlyDictionaryInts.ConstBegin();
            _itIntOp = _readOnlyDictionaryInts.ConstBegin();

            _itString = _readOnlyDictionaryStrings.ConstBegin();
            _itStringOp = _readOnlyDictionaryStrings.ConstBegin();
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_Integer_ConstIterator()
        {
            while (_itInt.Next()) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_Integer_ConstIterator_OperatorOverload()
        {
            while (_itIntOp++) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_Integer_Enumerator()
        {
            foreach (KeyValuePair<int, int> i in _readOnlyDictionaryInts) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_String_ConstIterator()
        {
            while (_itString.Next()) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_String_ConstIterator_OperatorOverload()
        {
            while (_itStringOp++) { }
        }

        [Benchmark]
        public void ReadOnlyDictionary_2_String_Enumerator()
        {
            foreach (KeyValuePair<string, string> s in _readOnlyDictionaryStrings) { }
        }
    }
}
